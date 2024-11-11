using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                    MessageBox.Show("Pago registrado y socio actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
