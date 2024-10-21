using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;


namespace club_deportivo
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? instancia = null;

        // Constructor privado para aplicar el patrón Singleton
        private Conexion()
        {
            this.baseDatos = "club_deportivo";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "";
        }

        // Método para crear la conexión
        public MySqlConnection CrearConexion()
        {
            MySqlConnection cadena = new MySqlConnection();

            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          ";port=" + this.puerto +
                                          ";username=" + this.usuario +
                                          ";password=" + this.clave +
                                          ";Database=" + this.baseDatos;
                cadena.Open(); // Abrimos la conexión
            }
            catch (Exception ex)
            {
                cadena = null;
                Console.WriteLine("Error: " + ex.Message); // Imprimimos el error
                throw; // Re-lanzamos la excepción para que sea capturada más arriba
            }
            return cadena;
        }

        // Método para obtener la instancia única (Singleton)
        public static Conexion GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new Conexion();
            }
            return instancia;
        }
    }
}

