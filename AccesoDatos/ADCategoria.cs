using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class ADCategoria
    {
        #region Propiedades

        public string CadConexion;
        #endregion

        #region Constructores
        public ADCategoria(string cadena)
        {
            CadConexion = cadena;
        }
        #endregion

        #region Metodos

        public bool claveCategoriaExiste(string clave)
        {
            bool result = false;
            string sentencia = "Select 1 from Categoria where claveCategoria = @clave";
            Object objeto;
            SqlConnection conexion = new SqlConnection(CadConexion);
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            comando.Parameters.AddWithValue("@clave",clave);
            try
            {
                conexion.Open();
                objeto = comando.ExecuteScalar();
                if (objeto != null)
                    result = true;
                conexion.Close();
            }
            catch (Exception)
            {
                conexion.Close();
                throw new Exception("Nose ha podido consultar la Clave de Categoría");
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
