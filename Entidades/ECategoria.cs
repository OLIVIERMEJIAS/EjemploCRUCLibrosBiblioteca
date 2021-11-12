using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class ECategoria
    {
        #region Atributos
            string claveCategoria;
            string descripcion;
        #endregion

        #region Propiedades
            public string ClaveCategoria { get; set; }
            public string Descripcion { get; set; }
        #endregion

        #region Constructores
            public ECategoria()
                    {
                        ClaveCategoria = string.Empty;
                        Descripcion = string.Empty;
                    }

                    public ECategoria(string claCate, string desc = "")
                    {
                        ClaveCategoria = claCate;
                        Descripcion = desc;
                    }
        #endregion
        


    }
}
