using System;
using System.Collections.Generic;
using System.Text;
using AccesoDatos;

namespace LogicaNegocio
{
    public class LNCategoria
    {
        #region Propiedades
        public string CadConexion { get; set; }
        #endregion

        #region Constructores

        public LNCategoria()
        {
            CadConexion = string.Empty;
        }

        public LNCategoria(string cadena)
        {
            CadConexion = cadena;
        }
        #endregion

        #region Metodos

        
        public bool claveCategoriaExiste(string clave)
        {
            bool result = false;
            ADCategoria adCat = new ADCategoria(CadConexion);
            try
            {
                if (adCat.claveCategoriaExiste(clave))
                    result = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;

        }
        #endregion
    }
}
