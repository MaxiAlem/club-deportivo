using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace club_deportivo.Datos
{
    internal class Usuarios
    {
        // Método que retorna una tabla con la información
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado; // Variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = null;

            try
            {
                // Llama al método CrearConexion correctamente
                sqlCon = club_deportivo.Conexion.GetInstancia().CrearConexion();

                // Comando para el procedimiento almacenado
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Definimos los parámetros que tiene el procedure
                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;

                // Ejecutamos el comando y llenamos la tabla
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message); // Para tener más detalles en caso de error
                throw;
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
