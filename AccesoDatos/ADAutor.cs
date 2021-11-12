using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class ADAutor
    {
        #region Propiedades
        public string CadConexion { get; set; }
        #endregion

        #region Constructores
        public ADAutor()
        {
            CadConexion = string.Empty;

        }

        public ADAutor (string cadena)
        {
            CadConexion = cadena;
        }
        #endregion

        #region Metodos

        public bool claveAutorExiste(string clave)
        {
            bool result = false;
            Object objeto;
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = "Select 1 from Autor where claveAutor = @clave";
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            comando.Parameters.AddWithValue("@clave", clave);
           

            try
            {
                conexion.Open();
                objeto = comando.ExecuteScalar();
                if (objeto != null)
                    result = true;
                else
                    result = false;
                conexion.Close();
            }
            catch (Exception)
            {
                conexion.Close();
                throw new Exception("No se puedo corroborar la consulta de Clave de Autor");
            }
            finally
            {
                comando.Dispose();
                conexion.Dispose();
            }
            return result;
        }

        #endregion
    }
}
