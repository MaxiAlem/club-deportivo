﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace club_deportivo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CargarSociosVencenHoy();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnNuevoSocio_Click(object sender, EventArgs e)
        {

            // Validar los campos requeridos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtTel.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!chkApto.Checked)
            {
                MessageBox.Show("Debe confirmar que el socio cumple con los requisitos marcando el checkbox.",
                                "Validación Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //VALIDACION
            // 
            string dni = txtDNI.Text;

            // Crear una instancia de ControlSocios
            ControlSocios control = new ControlSocios();

            // usamos el BuscarSocio y s da !null es xq ya existe uno
            Socios socioExistente = control.BuscarSocioPorDNI(dni);
            if (socioExistente != null)
            {
                MessageBox.Show("El socio ya está registrado. Nombre: " + socioExistente.Nombre + " " + socioExistente.Apellido,
                                "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Recoger los datos del formulario
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            // string dni = txtDNI.Text;  lo estamos capturanod mas arriba 
            string telefono = txtTel.Text;
            bool esSocio = false; // no es socio, todavia ;)
            bool carnetEntregado = false;

            //
            // Crear una instancia del objeto Socios sin id
            Socios nuevoSocio = new Socios(nombre, apellido, dni, telefono, esSocio)
            {
                FechaInscripcion = DateTime.Now,
                // FechaVencimientoCuota = DateTime.Now.AddMonths(1) // En caso de que como requisito al registro tenga que pagar el primer mes
            };



            // Crear una instancia de ControlSocios para manejar la operación de base de datos
            //ControlSocios control = new ControlSocios();
            bool exito = control.RegistrarSocio(nuevoSocio);

            // Mostrar el resultado de la operación
            if (exito)
            {
                MessageBox.Show("Socio agregado correctamente.");
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el socio.");
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtTel.Clear();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtBuscar.Text;

            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI para buscar.");
                return;
            }

            ControlSocios controlSocios = new ControlSocios();
            Socios socio = controlSocios.BuscarSocioPorDNI(dni);

            if (socio != null)
            {
                // Muestra la información del socio en los campos de texto
                // txtNombre.Text = socio.Nombre;
                //txtApellido.Text = socio.Apellido;
                //txtTel.Text = socio.Telefono;
                //chkEsSocio.Checked = socio.EsSocio;
                MessageBox.Show("Socio Encontrado: " + socio.Nombre + ", " + socio.Apellido);
                Form formulario = new Form3(socio); //le pasamo el socio para poder manosearlo 
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se encontró un socio con el DNI: " + dni);
                LimpiarCampos(); // Limpia los campos si no se encuentra el socio
            }
        }

        private void CargarSociosVencenHoy()
        {
            ControlSocios controlSocios = new ControlSocios();
            List<Socios> sociosVencidos = controlSocios.ObtenerSociosVencenHoy();

            if (sociosVencidos.Count > 0)
            {
                dgvSociosVencidos.AutoGenerateColumns = true; // Habilita la generación automática de columnas
                dgvSociosVencidos.DataSource = sociosVencidos.Select(s => new
                {
                    s.Nombre,
                    s.Apellido,
                    s.DNI,
                    s.Telefono,
                    FechaVencimiento = s.FechaVencimientoCuota.ToString("dd/MM/yyyy")
                }).ToList();

            }
            else
            {
                MessageBox.Show("No hay socios con cuotas vencidas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
