using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data.SqlClient;
namespace AccesoDatos
{
    public class ADLibro
    {
        private string cadConexion;
        private string mensaje;

        public string Mensaje { get; }

        #region Constructores
        public ADLibro()
        {
            cadConexion = string.Empty;
            mensaje = string.Empty;
        }

        public ADLibro(string cadena)
        {
            cadConexion = cadena;
            mensaje = string.Empty;
        }
        #endregion

        #region Metodos
        public bool libroRepetido(ELibro libro)
        {
            bool result = false;
            string sentencia;
            sentencia = $"Select 1 from Libro where titulo = {libro.Titulo} and claveAutor = {libro.ClaveAutor}";
            //1. CREAR OBJETOS DE DATOS DE ADO.NET
            SqlCommand comandoSQL = new SqlCommand();
            SqlConnection conexionSQL = new SqlConnection(cadConexion);
            SqlDataReader datos; //NO SE INSTANCIA

            //2. CONFIGURAR EL OBJETO DE DATOS
            comandoSQL.Connection = conexionSQL;
            comandoSQL.CommandText = sentencia;

            //3. ABRIR CONEXIÓN / EJECUTAR COMANDO / RECUPERAR DATOS
            try
            {
                conexionSQL.Open();
                datos = comandoSQL.ExecuteReader();
                conexionSQL.Close();
                //if (datos.HasRows)
                //    result = true;
                //else 
                //    result = false;
                result = datos.HasRows ? true : false;
            }
            catch (Exception)
            {

                throw new Exception("Se ha presentando un error realizando la consulta");
            } 
            //4. LIMPIAR MEMORIA
            finally
            {
                comandoSQL.Dispose();
                conexionSQL.Dispose();
            }

           
            return result;
        }

        public bool claveLibroRepetida(string clave)
        {
            bool result = false;
            Object objetoEscalar;
            //1
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection(cadConexion);
            SqlDataReader datos; //no se instancia
            //2
            comando.CommandText = "Select 1 from Libro where claveLibro = @claveLibro";
            comando.Parameters.AddWithValue("@claveLibro", clave);
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                objetoEscalar = comando.ExecuteScalar();
                conexion.Close();
                if (objetoEscalar != null)
                    result = true;
                else
                    result = false;
            }
            catch (Exception)
            {

                throw new Exception("Error buscando la clave del libro");

            }

            //3

            //4
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
