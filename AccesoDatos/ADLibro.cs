using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;
namespace AccesoDatos
{
    public class ADLibro
    {
        #region Atributos
         private string cadConexion;
         private string mensaje;
         public string Mensaje { get; }
        #endregion

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
            sentencia = $"Select 1 from Libro where titulo = '{libro.Titulo}' and claveAutor = '{libro.ClaveAutor}'";
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
                result = datos.HasRows ? true : false;
                conexionSQL.Close();
                //if (datos.HasRows)
                //    result = true;
                //else 
                //    result = false;
                
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
            //2
            comando.CommandText = "Select 1 from Libro where claveLibro = @claveLibro";
            comando.Parameters.AddWithValue("@claveLibro", clave);
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                objetoEscalar = comando.ExecuteScalar();
                if (objetoEscalar != null)
                    result = true;
                else
                    result = false;
                conexion.Close();
                
            }
            catch (Exception)
            {
                conexion.Close();
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
        
        public int insertar(ELibro libro)
        {   
            int result = -1;
            string sentencia = "Insert into Libro values(@claveLibro," +
                "@titulo,@claveAutor,@claveCategoria)";

            SqlConnection conexion = new SqlConnection(cadConexion);
            SqlCommand comando = new SqlCommand(sentencia,conexion);

            comando.Parameters.AddWithValue("@claveLibro", libro.ClaveLibro);
            comando.Parameters.AddWithValue("@titulo", libro.Titulo);
            comando.Parameters.AddWithValue("@claveAutor", libro.ClaveAutor);
            comando.Parameters.AddWithValue("@claveCategoria", libro.Categoria.ClaveCategoria);

            try
            {
                conexion.Open();
                result = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                conexion.Close();
                throw new Exception("No se ha ingresado el libro");
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }


            return result;
        }
        
        public DataSet listarTodos(string condicion = "")
        {
            DataSet setLibros = new DataSet();
            string sentencia = "Select claveLibro, titulo, claveAutor, " +
                "claveCategoria from Libro";
            if (!string.IsNullOrEmpty(condicion))
                sentencia = string.Format("{0} where {1}, sentencia, condicion");

            //sentencia = $"{sentencia} where {condicion}";

            SqlConnection conexion = new SqlConnection(cadConexion);
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(sentencia, conexion);
                adaptador.Fill(setLibros);
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

            return setLibros;
        }
        //Otro <List>

        public ELibro buscarRegistro(string condicion)
        {
            ELibro libro = new ELibro();
            string sentencia = "Select claveLibro, titulo, claveAutor, claveCategoria from Libro";
            SqlConnection conexion = new SqlConnection(cadConexion);

            sentencia = $"{sentencia} where {condicion}";

            SqlCommand comando = new SqlCommand(sentencia, conexion);
            SqlDataReader dato;

            try
            {
                conexion.Open();
                dato = comando.ExecuteReader();
                if(dato.HasRows)
                {
                    dato.Read();//Traerá un registro
                    libro.ClaveLibro = dato.GetString(0);
                    libro.Titulo = dato.GetString(1);
                    libro.ClaveAutor = dato.GetString(2);
                    libro.Categoria.ClaveCategoria =                dato.GetString(3);
                }
                conexion.Close();
            }
            catch (Exception)
            {

                throw new Exception("No se ha encontrado el libro");
            }
            finally
            {
                comando.Dispose();
                conexion.Dispose();
            }


            return libro;
        }
        
        #endregion
    }
}
