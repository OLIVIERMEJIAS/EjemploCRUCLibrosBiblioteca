using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class ADEjemplar
    {

        public string CadConexion { get; set; }

        public ADEjemplar()
        {
            CadConexion = string.Empty;
        }

       public ADEjemplar(string cad)
        {
            CadConexion = cad;
        }

        public DataSet listarEjemplares(string condic)
        {
            DataSet setEjem = new DataSet();
            string sentencia = "Select claveEjemplar, claveLibro, claveCondicion, " +
                "claveEstado, edicion, claveEditorial, numeroPaginas from Ejemplar";
            string condicion = $"where claveLibro = {condic}";
            sentencia = $"{sentencia} {condicion}";
            SqlConnection conexion = new SqlConnection(CadConexion);
            SqlDataAdapter adaptador;

            try
            {
                adaptador = new SqlDataAdapter(sentencia, conexion);
                adaptador.Fill(setEjem);
                adaptador.Dispose();
            }
            catch (Exception)
            {

                throw new Exception("Ha ocurrido algo!!!");
            }
            finally
            {
                conexion.Dispose();
            }

            return setEjem;
        }

        public void actualizarEstadoEjemplar(string estado, string claveEjem)
        {
           
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = $"Update Ejemplar Set claveEstado = '{estado}' where" +
                $" claveEjemplar = '{claveEjem}'";
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                conexion.Close();
                throw new Exception("No se logro actualizar el estado del ejemplar");
            }
            finally
            {
                comando.Dispose();
                conexion.Dispose();
            }
        }

        public bool buscarClaveEstado(string claveEjem)
        {
            bool result = false;
            Object escalar;
            string claveEstado;
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = "Select claveEstado from Ejemplar";
            string condicion = $"where claveEjemplar = '{claveEjem}'";
            sentencia = $"{sentencia} {condicion}";
            SqlCommand comando = new SqlCommand(sentencia,conexion);
            try
            {
                conexion.Open();
                escalar = comando.ExecuteScalar();
                claveEstado = escalar.ToString();
                conexion.Close();
                if (claveEstado == "ES002")
                {
                    actualizarEstadoEjemplar("ES003", claveEjem);
                    result = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {
                conexion.Close();
                throw new Exception("No se logro obtener el estado del ejemplar");
            }
            finally
            {
                comando.Dispose();
                conexion.Dispose();
            }


            return result;
        }
    }
}
