using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class ADUsuario
    {
        public string CadConexion { get; set; }

        public ADUsuario()
        {
            CadConexion = string.Empty;
        }

        public ADUsuario (string cad)
        {
            CadConexion = cad;
        }

        public bool existeUsuario(EUsuario usu)
        {
            bool result = false;
            SqlDataReader datos;
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sent = "Select nombre,apPaterno,apMaterno from Usuario where claveUsuario = @clave";
            SqlCommand comando = new SqlCommand(sent, conexion);

            comando.Parameters.AddWithValue("@clave", usu.ClaveUsuario);
            
            try
            {
                conexion.Open();
                datos = comando.ExecuteReader();
                if(datos.HasRows)
                {
                    result =  true;
                    datos.Read();
                    usu.Nombre = datos.GetString(0);
                    usu.ApPaterno = datos.GetString(1);
                    usu.ApMaterno = datos.GetString(2);
                }
                conexion.Close();
            }
            catch (Exception EX)
            {

                throw EX
                    ;
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
