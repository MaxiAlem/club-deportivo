using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace club_deportivo
{
    internal class ControlSocios

    {

        // Metdo para insertar un nuevo socio
        public bool RegistrarSocio(Socios socio)
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

                // params
                com.Parameters.AddWithValue("_Nombre", socio.Nombre);
                com.Parameters.AddWithValue("_Apellido", socio.Apellido);
                com.Parameters.AddWithValue("_DNI", socio.DNI);
                com.Parameters.AddWithValue("_Telefono", socio.Telefono);
                com.Parameters.AddWithValue("_EsSocio", socio.EsSocio ? 1 : 0);
                com.Parameters.AddWithValue("_FechaInscripcion", DateTime.Now); // fecha actual
                com.Parameters.AddWithValue("_FechaVencimientoCuota", DBNull.Value); // naranja por ahora
                com.Parameters.AddWithValue("_CarnetEntregado", 0); // 0 = No entregado
             


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

        public bool EliminarSocio(string dni)
        {
            MySqlConnection sqlCon = null;

            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();

                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                }

                MySqlCommand com = new MySqlCommand("EliminarSocio", sqlCon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("_DNI", MySqlDbType.VarChar).Value = dni;

                com.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                sqlCon?.Close();
            }
        }

        public Socios BuscarSocioPorDNI(string dni)
        {
            MySqlConnection sqlCon = null;
            Socios socio = null;

            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();

                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                }

                MySqlCommand com = new MySqlCommand("BuscarSocioPorDNI", sqlCon);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("_DNI", MySqlDbType.VarChar).Value = dni;

                using (MySqlDataReader reader = com.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string nombre = reader["Nombre"]?.ToString() ?? string.Empty;
                        string apellido = reader["Apellido"]?.ToString() ?? string.Empty;
                        string telefono = reader["Telefono"]?.ToString() ?? string.Empty;
                        bool esSocio = reader["EsSocio"] != DBNull.Value && Convert.ToBoolean(reader["EsSocio"]);
                        bool carnetEntregado = reader["CarnetEntregado"] != DBNull.Value && Convert.ToBoolean(reader["CarnetEntregado"]);
                        DateTime fechaInscripcion = reader["FechaInscripcion"] != DBNull.Value ? Convert.ToDateTime(reader["FechaInscripcion"]) : DateTime.MinValue;
                        DateTime fechaVencimientoCuota = reader["FechaVencimientoCuota"] != DBNull.Value ? Convert.ToDateTime(reader["FechaVencimientoCuota"]) : DateTime.MinValue;

                        socio = new Socios(id, nombre, apellido, dni, telefono, esSocio, carnetEntregado, fechaInscripcion, fechaVencimientoCuota);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlCon?.Close();
            }

            return socio;
        }
        public Socios BuscarSocioPorId(int idSocio)
        {
            MySqlConnection sqlCon = null;
            Socios socio = null;

            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();

                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                }

                MySqlCommand com = new MySqlCommand("SELECT * FROM socios WHERE Id = @Id", sqlCon);
                com.Parameters.AddWithValue("@Id", idSocio);

                using (MySqlDataReader reader = com.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string nombre = reader["Nombre"]?.ToString() ?? string.Empty;
                        string apellido = reader["Apellido"]?.ToString() ?? string.Empty;
                        string telefono = reader["Telefono"]?.ToString() ?? string.Empty;
                        bool esSocio = reader["EsSocio"] != DBNull.Value && Convert.ToBoolean(reader["EsSocio"]);
                        bool carnetEntregado = reader["CarnetEntregado"] != DBNull.Value && Convert.ToBoolean(reader["CarnetEntregado"]);
                        DateTime fechaInscripcion = reader["FechaInscripcion"] != DBNull.Value ? Convert.ToDateTime(reader["FechaInscripcion"]) : DateTime.MinValue;
                        DateTime fechaVencimientoCuota = reader["FechaVencimientoCuota"] != DBNull.Value ? Convert.ToDateTime(reader["FechaVencimientoCuota"]) : DateTime.MinValue;
                        string dni = reader["DNI"]?.ToString() ?? string.Empty; // Obtener el valor de DNI de la base de datos

                        socio = new Socios(id, nombre, apellido, telefono,dni, esSocio, carnetEntregado, fechaInscripcion, fechaVencimientoCuota);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                sqlCon?.Close();
            }

            return socio;
        }

        public bool ModificarVencimientoYSocioPorId(int idSocio, string pagoDe)
        {
            MySqlConnection sqlCon = null;
            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();
                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                }

                // Buscar al socio y actualizar su vencimiento y estado
                Socios socio = BuscarSocioPorId(idSocio);

                if (socio == null)
                {
                    MessageBox.Show("Socio no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Calcula la nueva fecha de vencimiento en la clase Socios
                socio.CalcularFechaVencimiento(pagoDe);

                MySqlCommand com = new MySqlCommand("ModificarSocio", sqlCon);
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("_Id", idSocio);
                com.Parameters.AddWithValue("_FechaVencimientoCuota", socio.FechaVencimientoCuota);
                com.Parameters.AddWithValue("_EsSocio", socio.EsSocio ? 1 : 0);

                com.ExecuteNonQuery();

                MessageBox.Show("Socio actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                sqlCon?.Close();
            }
        }
        public List<Socios> ListarTodosLosSocios()
        {
            MySqlConnection sqlCon = null;
            List<Socios> listaSocios = new List<Socios>();

            try
            {
                sqlCon = Conexion.GetInstancia().CrearConexion();

                if (sqlCon.State != ConnectionState.Open)
                {
                    sqlCon.Open();
                }

                MySqlCommand com = new MySqlCommand("ListarSocios", sqlCon);
                com.CommandType = CommandType.StoredProcedure;

                using (MySqlDataReader reader = com.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string nombre = reader["Nombre"]?.ToString() ?? string.Empty;
                        string apellido = reader["Apellido"]?.ToString() ?? string.Empty;
                        string telefono = reader["Telefono"]?.ToString() ?? string.Empty;
                        bool esSocio = reader["EsSocio"] != DBNull.Value && Convert.ToBoolean(reader["EsSocio"]);
                        bool carnetEntregado = reader["CarnetEntregado"] != DBNull.Value && Convert.ToBoolean(reader["CarnetEntregado"]);
                        DateTime fechaInscripcion = reader["FechaInscripcion"] != DBNull.Value ? Convert.ToDateTime(reader["FechaInscripcion"]) : DateTime.MinValue;
                        DateTime fechaVencimientoCuota = reader["FechaVencimientoCuota"] != DBNull.Value ? Convert.ToDateTime(reader["FechaVencimientoCuota"]) : DateTime.MinValue;
                        string dni = reader["DNI"]?.ToString() ?? string.Empty; // Obtener el valor de DNI de la base de datos

                        Socios socio = new Socios(id, nombre, apellido, dni, telefono, esSocio, carnetEntregado, fechaInscripcion, fechaVencimientoCuota);
                        listaSocios.Add(socio);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                sqlCon?.Close();
            }

            return listaSocios;
        }

    }
}

