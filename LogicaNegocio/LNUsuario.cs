using System;
using System.Collections.Generic;
using System.Text;
using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class LNUsuario
    {
        public string CadConexion { get; set; }

        public LNUsuario()
        {
            CadConexion = string.Empty;
        }

        public LNUsuario(string cad)
        {
            CadConexion = cad;
        }

        public bool existeUsuario(EUsuario usu)
        {
            bool result = false;
            ADUsuario adUsu = new ADUsuario(CadConexion);

            try
            {
                result = adUsu.existeUsuario(usu);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }
    }
}
