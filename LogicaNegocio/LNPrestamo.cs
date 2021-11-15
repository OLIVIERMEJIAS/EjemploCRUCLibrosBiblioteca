using System;
using System.Collections.Generic;
using System.Text;
using AccesoDatos;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace LogicaNegocio
{
    public class LNPrestamo
    {
        
        public string CadConexion { get; set; }

        public LNPrestamo()
        {
            CadConexion = string.Empty;
        }

        public LNPrestamo(string cad)
        {
            CadConexion = cad;
        }

        public bool registrarPrestamo(EPrestamo prestamo)
        {
            bool result = false;
            ADPrestamo adP = new ADPrestamo(CadConexion);

            try
            {
                result = adP.registrarPrestamo(prestamo);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return result;
        }

        public DataSet listarPrestamos(EUsuario usu)
        {   
            ADPrestamo adP = new ADPrestamo(CadConexion);
            DataSet tablePrest;
            try
            {
               tablePrest =  adP.listarPrestamos(usu);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return tablePrest;
        }

        public bool eliminarPrestamo(string clave)
        {
            bool result = false;
            ADPrestamo adP = new ADPrestamo(CadConexion);
            try
            {
                result = adP.eliminarPrestamo(clave);
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }
    }
}
