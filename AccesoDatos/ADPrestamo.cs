using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace AccesoDatos
{
    public class ADPrestamo
    {
        public string CadConexion { get; set; }

        public ADPrestamo()
        {
            CadConexion = string.Empty;
        }

        public ADPrestamo(string cad)
        {
            CadConexion = cad;
        }

        public bool registrarPrestamo(EPrestamo prestamo)
        {
            bool result = false;
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = "Insert Into Prestamo Values(@claveP,@claveE,@claveU,@fechaP,@fechaD)";
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            comando.Parameters.AddWithValue("@claveP", prestamo.ClavePrestamo);
            comando.Parameters.AddWithValue("@claveE", prestamo.ClaveEjemplar);
            comando.Parameters.AddWithValue("@claveU", prestamo.ClaveUsuario);
            comando.Parameters.AddWithValue("@fechaP", prestamo.FechaPrestamo.ToString());
            comando.Parameters.AddWithValue("@fechaD", prestamo.FechaDevolucion.ToString());
             conexion.Open();
                if (comando.ExecuteNonQuery() != null)
                {
                    result = true;
                }
                conexion.Close();
            try
            {
               
            }
            catch (Exception)
            {
                conexion.Close();
                throw new Exception("No se logró registrar el préstamo");
            }
            finally
            {
                comando.Dispose();
                conexion.Dispose();
            }


            return result;
        }

        public bool eliminarPrestamo(string clave)
        {
            bool result = false;
            string claveEstado;
            SqlConnection conexion = new SqlConnection(CadConexion);
            string sentencia = "Delete from Prestamo";
            string condicion = $"where clavePrestamo = '{clave}'";
            sentencia = $"{sentencia} {condicion}";
            SqlCommand comando = new SqlCommand(sentencia, conexion);
            try
            {
                conexion.Open();
                if(comando.ExecuteNonQuery() != null)
                {
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

        public DataSet listarPrestamos(EUsuario usu)
        {

            DataSet setPrest = new DataSet();
            string sentencia = "Select p.clavePrestamo, p.claveEjemplar, p.claveUsuario, " +
                "p.fechaPrestamo, p.fechaDevolucion from Prestamo p inner join Ejemplar e " +
                "On p.claveEjemplar = e.claveEjemplar";
            string condicion = $"p.claveUsuario = '{usu.ClaveUsuario}' and e.claveEstado = 'ES002'";
                sentencia = $"{sentencia} where {condicion}";
            SqlConnection conexion = new SqlConnection(CadConexion);
            SqlDataAdapter adaptador;
            adaptador = new SqlDataAdapter(sentencia, conexion);
                adaptador.Fill(setPrest);
                adaptador.Dispose();
            try
            {
                
            }
            catch (Exception)
            {

                throw new Exception("Ha ocurrido algo!!!");
            }
            finally
            {
                conexion.Dispose();
            }

            return setPrest;
        }
    }
}
