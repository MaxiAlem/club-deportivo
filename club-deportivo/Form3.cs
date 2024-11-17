using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace club_deportivo
{
    public partial class Form3 : Form
    {

        private Socios socio;  // Variable para almacenar el socio
        public Form3(Socios socio)
        {
            InitializeComponent();

            this.socio = socio;  // Asignar el socio al formulario
            // Llamar a un método para cargar los datos
            CargarDatos(socio);

            //cargar datos al combobox de tipo de pago

            cmbTPago.Items.Add("Efectivo");
            cmbTPago.Items.Add("Tarjeta de Crédito");
            cmbTPago.Items.Add("Transferencia Bancaria");
            cmbTPago.Items.Add("PayPal");

            // Seleccionar el primer valor por defecto (opcional)
            cmbTPago.SelectedIndex = 0;


            //cargar datos al combobox de tipo de pago

            cmbPagode.Items.Add("Día");
            cmbPagode.Items.Add("Mes");

            // Seleccionar el primer valor por defecto (opcional)
            cmbPagode.SelectedIndex = 0;
        }

        private void CargarDatos(Socios socio)
        {
            // Asignar los valores del socio a los campos correspondientes
            txtNombre.Text = socio.Nombre; // Aquí asignamos el nombre del socio al TextBox correspondiente
            txtApellido.Text = socio.Apellido;
            txtTel.Text = socio.Telefono;
            txtDNI.Text = socio.DNI;



            // Si la fecha de vencimiento es mínima, asignar la fecha de inscripción
            if (socio.FechaVencimientoCuota == DateTime.MinValue)
            {
                socio.FechaVencimientoCuota = socio.FechaInscripcion;
            }

            txtFechaVencimiento.Text = socio.FechaVencimientoCuota.ToString("dd/MM/yyyy"); // Mostrar la fecha de vencimiento

        }

        private void BtnRegistrarPago_Click(object sender, EventArgs e)
        {
            // Recoger los datos del pago
            string tipoPago = cmbTPago.SelectedItem.ToString() ?? "";
            string pagoDe = cmbPagode.SelectedItem.ToString() ?? "";
            string monto = txtValorPago.Text;

            // Verificar que el campo de monto !vacío
            if (string.IsNullOrWhiteSpace(monto))
            {
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear el objeto Pago
            Pago nuevoPago = new Pago(socio.Id, pagoDe, monto, tipoPago, DateTime.Now);


            // Llamar al método para registrar el pago desde la clase Pago
            if (nuevoPago.RegistrarPago())
            {
                // Si el pago se registra exitosamente, modificar el vencimiento y estado del socio
                ControlSocios controlSocios = new ControlSocios();
                if (controlSocios.ModificarVencimientoYSocioPorId(socio.Id, pagoDe))
                {

                    MessageBox.Show("Pago registrado y socio actualizado correctamente.Se imprimirá un comprobante del Pago", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ImprimirComprobante(nuevoPago);

                }
                else
                {
                    MessageBox.Show("Pago registrado, pero no se pudo actualizar el socio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No se pudo registrar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGenCarnet_click(object sender, EventArgs e)
        {
            if (socio == null || socio.Id <= 0)
            {
                MessageBox.Show("No se pudo obtener el ID del socio para generar el carnet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  nueva instancia del formpasando el ID
            Carnet carnet = new Carnet(socio.Id);
            carnet.ShowDialog();
        }

        private void ImprimirComprobante(Pago pago)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (sender, e) =>
            {
                Font font = new Font("Arial", 12);
                float yPosition = 10;
                float lineHeight = font.GetHeight(e.Graphics);

                // Título del comprobante
                e.Graphics.DrawString("Comprobante de Pago", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 10, yPosition);
                yPosition += lineHeight * 2;

                // Información del socio
                e.Graphics.DrawString($"Nombre: {socio.Nombre} {socio.Apellido}", font, Brushes.Black, 10, yPosition);
                yPosition += lineHeight;
                e.Graphics.DrawString($"DNI: {socio.DNI}", font, Brushes.Black, 10, yPosition);
                yPosition += lineHeight;
                e.Graphics.DrawString($"Teléfono: {socio.Telefono}", font, Brushes.Black, 10, yPosition);
                yPosition += lineHeight * 2;

                // Información del pago
                e.Graphics.DrawString($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", font, Brushes.Black, 10, yPosition);
                yPosition += lineHeight;
                e.Graphics.DrawString($"Tipo de Pago: {pago.TipoPago}", font, Brushes.Black, 10, yPosition);
                yPosition += lineHeight;
                e.Graphics.DrawString($"Concepto: {pago.PagoDe}", font, Brushes.Black, 10, yPosition);
                yPosition += lineHeight;
                e.Graphics.DrawString($"Monto: {pago.Monto} ARS", font, Brushes.Black, 10, yPosition);
                yPosition += lineHeight * 2;

                // Pie del comprobante
                e.Graphics.DrawString("Gracias por su pago.", font, Brushes.Black, 10, yPosition);
            };

            try
            {
                PrintDialog printDialog = new PrintDialog
                {
                    Document = printDocument
                };

                // Mostrar diálogo de impresión
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir el comprobante: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
