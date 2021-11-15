using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EPrestamo
    {
        public string ClavePrestamo { get; set; }
        public string ClaveEjemplar { get; set; }
        public string ClaveUsuario { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public EPrestamo()
        {
            ClavePrestamo = string.Empty;
            ClaveEjemplar = string.Empty;
            ClaveUsuario = string.Empty;
            FechaPrestamo = DateTime.Today;
            FechaDevolucion = DateTime.MaxValue;
        }

        public EPrestamo(string claveP, string claveE, string claveU,
         DateTime fechDev)
        {
            ClavePrestamo = claveP;
            ClaveEjemplar = claveE;
            ClaveUsuario = claveU;
  
            FechaDevolucion = fechDev;
        }
    }
}
