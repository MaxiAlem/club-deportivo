using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club_deportivo
{
    internal class Socios
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string telefono;
        private List<string> actividades = new List<string>();
        // Constructor
        public Socios( string nombre, string apellido,string dni, string telefono )
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.telefono = telefono;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public bool TieneTopeDeActividades()
        {
            return actividades.Count >= 3;
        }

        public void InscribirActividad(string actividad)
        {
            if (actividades.Count < 3)
            {
                actividades.Add(actividad);
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {nombre} {apellido}, DNI: {dni}, Teléfono: {telefono}");
            for (int i = 0; i < actividades.Count; i++)
            {
                Console.WriteLine($"Actividad {i + 1}: {actividades[i]}");
            }
        }

        // Metdo para insertar un nuevo socio
        public bool InsertarSocio()
        {
            MySqlConnection sqlCon = null;

            try
            {
                // Llama al CrearConexion
                sqlCon = Conexion.GetInstancia().CrearConexion();

                // verif si  conn = open antes de abrirla
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                }

                // Comando para el procedimiento almacenado
                MySqlCommand com = new MySqlCommand("InsertarSocio", sqlCon);
                com.CommandType = CommandType.StoredProcedure;

            
                com.Parameters.Add("_Nombre", MySqlDbType.VarChar).Value = this.nombre;
                com.Parameters.Add("_Apellido", MySqlDbType.VarChar).Value = this.apellido;
                com.Parameters.Add("_DNI", MySqlDbType.VarChar).Value = this.dni;
                com.Parameters.Add("_Telefono", MySqlDbType.VarChar).Value = this.telefono;

                //fecha de alta 
                com.Parameters.Add("@_FechaAlta", MySqlDbType.Date).Value = DateTime.Now;


                // otros campos,
                com.Parameters.Add("@_FechaVencimientoCuota", MySqlDbType.Date).Value = DBNull.Value; 
                com.Parameters.Add("@_CarnetEntregado", MySqlDbType.Byte).Value = 0; // no entregado
                com.Parameters.Add("@_Activo", MySqlDbType.Byte).Value = 1; // activo

                com.ExecuteNonQuery();

                return true; // Retornamos true si la operación fue exitosa
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message); // Mensaje de error
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   

                return false;
            }
            finally
            {
                // Aseguramos que sqlCon no sea null antes de intentar cerrarlo
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}
