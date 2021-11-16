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
            FechaPrestamo = new DateTime();
            FechaDevolucion = new DateTime();
        }

        public EPrestamo(string claveP, string claveE, string claveU,DateTime fechaP,
         DateTime fechDev)
        {
            ClavePrestamo = claveP;
            ClaveEjemplar = claveE;
            FechaPrestamo = fechaP;
            ClaveUsuario = claveU;
            FechaDevolucion = fechDev;
        }
    }
}
