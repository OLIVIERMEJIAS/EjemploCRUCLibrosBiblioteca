using AccesoDatos;
using Entidades;
using System;

namespace LogicaNegocio
{
    public class LNAutor
    {
        #region Propiedades
        public string CadConexion { get; set; }
        #endregion

        #region Constructores

        public LNAutor()
        {
            CadConexion = string.Empty;
        }

        public LNAutor (string cadena)
        {
            CadConexion = cadena;
        }
        #endregion

        #region Metodos
            public bool claveAutorExiste(string clave)
                    {
                        bool result = false;
                        ADAutor adAutor = new ADAutor(CadConexion);
                        try
                        {
                            if (adAutor.claveAutorExiste(clave))
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
