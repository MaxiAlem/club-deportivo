using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using club_deportivo;

namespace TP1DSOO
{
    internal class ClubDeportivo
    {
        private List<Socios> socios = new List<Socios>();
        private List<Actividad> actividades = new List<Actividad>();
        private int contadorId = 1;



        // Metodo para agregar una actividad al club
        public void AgregarActividad(string nombreActividad, int cupos)
        {
            actividades.Add(new Actividad(nombreActividad, cupos));
            Console.WriteLine($"Actividad {nombreActividad} agregada con {cupos} cupos disponibles.");
        }

      
    }
}
