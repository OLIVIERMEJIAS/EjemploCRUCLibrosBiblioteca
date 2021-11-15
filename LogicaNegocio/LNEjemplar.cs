using System;
using System.Collections.Generic;
using System.Text;
using AccesoDatos;
using System.Data.SqlClient;
using System.Data;

namespace LogicaNegocio
{
    public class LNEjemplar
    {
        public string CadConexion { get; set; }

        public LNEjemplar()
        {
            CadConexion = string.Empty;
        }

        public LNEjemplar(string cad)
        {
            CadConexion = cad;
        }

        public DataSet listarEjemplares(string condic)
        {
            DataSet datos = new DataSet();
            ADEjemplar adE = new ADEjemplar(CadConexion);
            try
            {
                datos = adE.listarEjemplares(condic);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return datos;
        }

        public bool buscarClaveEstado(string claveEjem)
        {
            bool result = false;
            ADEjemplar adE = new ADEjemplar(CadConexion);
            try
            {
                result = adE.buscarClaveEstado(claveEjem);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        }

        public void actualizarEstadoEjemplar(string estado, string claveEjem)
        {
            ADEjemplar adE = new ADEjemplar(CadConexion);
            try
            {
                adE.actualizarEstadoEjemplar(estado, claveEjem);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
