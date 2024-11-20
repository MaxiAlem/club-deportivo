using System;
using System.Collections.Generic;

namespace club_deportivo
{
    public class Socios
    {
        // Propiedades públicas para acceder desde otras clases
        public int Id { get; set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string DNI { get; private set; }
        public string Telefono { get; private set; }
        public bool EsSocio { get; private set; }
        public bool CarnetEntregado { get; private set; }

        public DateTime FechaInscripcion { get; set; }
        public DateTime FechaVencimientoCuota { get; set; }

        //private List<string> actividades = new List<string>();

        // Constructores
 

        // Constructor Nuevos
        public Socios(string nombre, string apellido, string dni, string telefono, bool esSocio)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Telefono = telefono;
            EsSocio = esSocio;
            FechaInscripcion = DateTime.Now; // se asigna la fecha actual al inscribir
            FechaVencimientoCuota = DateTime.Now; // asume una primera cuota
        }

        // Constructor que requiere id(p instanciar al socio cuanod vuelve de la db
        public Socios(int id, string nombre, string apellido, string dni, string telefono, bool esSocio,bool carnetEntregado, DateTime fechaInscripcion, DateTime fechaVencimientoCuota)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Telefono = telefono;
            EsSocio = esSocio;
            CarnetEntregado = carnetEntregado;
            FechaInscripcion = fechaInscripcion;
            FechaVencimientoCuota = fechaVencimientoCuota;
        }

       
        // Método para calcular la fecha de vencimiento según el tipo de pago
        public void CalcularFechaVencimiento(string pagoDe)
        {
            switch (pagoDe)
            {
                case "Día":
                    FechaVencimientoCuota = DateTime.Now.AddDays(1);
                    break;
                case "Mes":
                    FechaVencimientoCuota = DateTime.Now.AddMonths(1);
                    EsSocio = true;
                    break;
                default:
                    throw new ArgumentException("Tipo de pago no reconocido" + pagoDe);
            }
        }

        //public bool TieneTopeDeActividades()
        //{
        //    return actividades.Count >= 3;
        //}

        //public void InscribirActividad(string actividad)
        //{
        //    if (actividades.Count < 3)
        //    {
        //        actividades.Add(actividad);
        //    }
        //}

        //public void MostrarInfo()
        //{
        //    Console.WriteLine($"Nombre: {Nombre} {Apellido}, DNI: {DNI}, Teléfono: {Telefono}");
        //    for (int i = 0; i < actividades.Count; i++)
        //    {
        //        Console.WriteLine($"Actividad {i + 1}: {actividades[i]}");
        //    }
        //}
    }
}
