using club_deportivo;
using System;
using System.Windows.Forms;

namespace club_deportivo

{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Este es el form con el que arranca 
            Application.Run(new Form1());
        }
    }
}
