using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace club_deportivo
{
    public class Pago
    {

        public int IdSocio { get; set; }
        public string PagoDe { get; set; }
        public string Monto { get; set; }
        public string TipoPago { get; set; }
        public DateTime FechadePago { get; set; }

        // Constructor para inicializar un nuevo pago
        public Pago(int idSocio, string pagoDe, string monto, string tipoPago, DateTime fechadePago)
        {
            IdSocio = idSocio;
            PagoDe = pagoDe;
            Monto = monto;
            TipoPago = tipoPago;
            FechadePago = fechadePago;
        }

        public bool RegistrarPago()
        {
            MySqlConnection sqlCon = null;
            bool registrado = false;

            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();

                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                }

                // Comando SQL para insertar un nuevo pago en registropagos
                MySqlCommand com = new MySqlCommand(
                    "RegistrarPago",
                    sqlCon
                )
                {
                    CommandType = CommandType.StoredProcedure  // Aseguremos que se use un stored procedure vieja
                };
                com.Parameters.AddWithValue("_IdSocio", IdSocio);
                com.Parameters.AddWithValue("_PagoDe", PagoDe);
                com.Parameters.AddWithValue("_Monto", Monto);
                com.Parameters.AddWithValue("_TipoPago", TipoPago);
                com.Parameters.AddWithValue("_FechadePago", FechadePago);
                // Ejecutar el comando
                com.ExecuteNonQuery();
                registrado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar el pago: " + ex.Message);
                MessageBox.Show("Error al registrar el pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlCon?.Close();
            }

            return registrado;
        }
    }
}
