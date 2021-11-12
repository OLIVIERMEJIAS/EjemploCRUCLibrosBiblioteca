using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EAutor
    {
        #region Propiedades
        public string ClaveAutor {get; set;}
        public string Nombre { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }


        #endregion

        #region Constructor
        public EAutor()
        {
            ClaveAutor = string.Empty;
            Nombre = string.Empty; 
            ApePaterno = string.Empty; 
            ApeMaterno = string.Empty; 
        }

        public EAutor (string clave, string nom = "", string apePat = "", string apeMat = "")
        {
            ClaveAutor = clave;
            Nombre = nom;
            ApePaterno = apePat;
            ApeMaterno = apeMat;
        }
        #endregion



    }
}
