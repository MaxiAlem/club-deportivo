using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class Carnet : Form
    {
        private int socioId;
        // Constructor con parámetro para recibir el socioId
        public Carnet(int id)
        {
            InitializeComponent();
            socioId = id;

            // Cargar datos del socio
            CargarDatosSocio();
        }
        private void CargarDatosSocio()
        {
            ControlSocios controlSocios = new ControlSocios();
            Socios socio = controlSocios.BuscarSocioPorId(socioId);

            if (socio != null)
            {
                // Cargar los datos en el formulario
                lblNombre.Text = $"{socio.Nombre}";
                lblApellido.Text = $"{socio.Apellido}";
                lblDNI.Text = socio.DNI;
                //lblID.Text = socio.Id.ToString();
                lblVencimiento.Text = socio.FechaVencimientoCuota.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los datos del socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Cierra el formulario si no se puede cargar
            }
        }

        private void bntPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            // Mostrar un diálogo de impresión para seleccionar impresora
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print(); // Imprimir si el usuario confirma
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Definir el área de impresión
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 12, FontStyle.Regular);
            Brush brush = Brushes.Black;

            int startX = 50;  // Margen izquierdo
            int startY = 50;  // Margen superior
            int offset = 30;  // Espaciado entre líneas

            // Dibujar contenido en el documento
            g.DrawString("Carnet de Socio", new Font("Arial", 16, FontStyle.Bold), brush, startX, startY);
            g.DrawString($"Nombre: {lblNombre.Text}", font, brush, startX, startY + offset);
            g.DrawString($"Apellido: {lblApellido.Text}", font, brush, startX, startY + offset * 2);
            g.DrawString($"DNI: {lblDNI.Text}", font, brush, startX, startY + offset * 3);
            g.DrawString($"ID: {socioId}", font, brush, startX, startY + offset * 4);
            g.DrawString($"Vencimiento: {lblVencimiento.Text}", font, brush, startX, startY + offset * 5);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }


}
