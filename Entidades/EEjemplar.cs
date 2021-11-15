using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EEjemplar
    {
        public string ClaveEjemplar { get; set; }
        public string ClaveLibro { get; set; }
        public char ClaveCondicion { get; set; }
        public string ClaveEstado { get; set; }
        public string Edicion { get; set; }
        public string ClaveEditorial { get; set; }
        public int NumeroPaginas { get; set; }

        public EEjemplar()
        {
            ClaveEjemplar = string.Empty;
            ClaveLibro = string.Empty;
            ClaveCondicion = ' ';
            ClaveEstado = string.Empty;
            Edicion = string.Empty;
            ClaveEditorial = string.Empty;
            NumeroPaginas = 0;
        }

        public EEjemplar(string ejem, string lib, string est, char cond, string edic,
            string edito, int num)
        {
            ClaveEjemplar = ejem;
            ClaveLibro = lib;
            ClaveCondicion = cond;
            ClaveEstado = est;
            Edicion = edic;
            ClaveEditorial = edito;
            NumeroPaginas = 0;
        }
    }
}
