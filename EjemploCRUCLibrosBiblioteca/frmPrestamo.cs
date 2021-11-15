using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using Entidades;

namespace EjemploCRUCLibrosBiblioteca
{
    public partial class frmPrestamo : Form
    {
        
        LNUsuario lnUsu = new LNUsuario(Config.getCadConexion);
        LNPrestamo lnP = new LNPrestamo(Config.getCadConexion);
        LNEjemplar lnE = new LNEjemplar(Config.getCadConexion);
        EGlobal glob = new EGlobal();
        public frmPrestamo()
        {
            InitializeComponent();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            bool result;
            EUsuario usu = new EUsuario(txtClave.Text);
            try
            {
                result = lnUsu.existeUsuario(usu);
                if (result)
                {
                    txtNombre.Text = $"{usu.Nombre} {usu.ApPaterno} {usu.ApMaterno}";
                    DataSet tablePrest = lnP.listarPrestamos(usu);
                    dgvPrestamos.DataSource = tablePrest.Tables[0];
                    dgvPrestamos.Columns[0].HeaderText = "Clave de Préstamo";
                    dgvPrestamos.Columns[1].HeaderText = "Clave de Ejemplar";
                    dgvPrestamos.Columns[2].HeaderText = "Clave de Usuario";
                    dgvPrestamos.Columns[3].HeaderText = "Fecha Préstamo";
                    dgvPrestamos.Columns[3].HeaderText = "Fecha Devolución";

                    dgvLibros.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                }
                else
                {
                    MessageBox.Show("No existe este usuario", "Error!!");
                    txtClave.Clear();
                    txtNombre.Clear();
                    dgvPrestamos.DataSource = null;
                    txtClave.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void llenarDGV(string condicion = "")
        {
            LNLibro ln = new LNLibro(Config.getCadConexion);
            DataSet ds;
            try
            {
                ds = ln.listarTodos(condicion);
                //ds = ln.listarTodos("titulo like %amor%");

                dgvLibros.DataSource = ds.Tables[0];
                dgvLibros.Columns[0].HeaderText = "Clave de Libro";
                dgvLibros.Columns[1].HeaderText = "Título";
                dgvLibros.Columns[2].HeaderText = "Clave de Autor";
                dgvLibros.Columns[3].HeaderText = "Clave de Categoría";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
            private void txtNombreLibro_TextChanged(object sender, EventArgs e)
            {
            string condicion = txtNombreLibro.Text;
                    llenarDGV($"titulo like '%{condicion}'");
            }

        private void btnEjemplares_Click(object sender, EventArgs e)
        {
            int fila = dgvLibros.CurrentRow.Index;
            string clave = dgvLibros[0, fila].Value.ToString();
            string condicion = $"'{clave}' and claveEstado = 'ES003'";
            DataSet ds;
            try
            {
                ds = lnE.listarEjemplares(condicion);
                dgvEjemplares.DataSource = ds.Tables[0];
                dgvEjemplares.Columns[0].HeaderText = "Clave de Ejemplar";
                dgvEjemplares.Columns[1].HeaderText = "Clave de Libro";
                dgvEjemplares.Columns[2].HeaderText = "Clave de Condición";
                dgvEjemplares.Columns[3].HeaderText = "Clave de Estado";
                dgvEjemplares.Columns[4].HeaderText = "Edición";
                dgvEjemplares.Columns[5].HeaderText = "Clave de Editorial";
                dgvEjemplares.Columns[6].HeaderText = "Número de Páginas";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void brnDevol_Click(object sender, EventArgs e)
        {
            bool result;
            int fila = dgvPrestamos.CurrentRow.Index;
            string claveEjemplar = dgvPrestamos[1,fila].Value.ToString();
            try
            {
                result = lnE.buscarClaveEstado(claveEjemplar);
                if (result)
                {
                    MessageBox.Show("Se ha devuelto el libro exitosamente!!!");

                }
                else
                    MessageBox.Show("El libro no se encuentra préstado!!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnElimPresta_Click(object sender, EventArgs e)
        {
           
            int fila = dgvPrestamos.CurrentRow.Index;
            string clavePrest = dgvPrestamos[0, fila].Value.ToString();
            string claveEjemplar = dgvPrestamos[1, fila].Value.ToString();
            try
            {
                if (!lnE.buscarClaveEstado(claveEjemplar))
                {
                    if (lnP.eliminarPrestamo(clavePrest))
                    {
                        MessageBox.Show("Se ha eliminado el préstamo exitosamente!!!");
                        btnBuscarUsuario_Click(sender, e);
                    }
                }
                else
                {
                    if (lnP.eliminarPrestamo(clavePrest))
                    {
                        MessageBox.Show("Se ha eliminado el préstamo exitosamente, pero se debió devolver el libro antes!!!");
                        btnBuscarUsuario_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrestarEjemplar_Click(object sender, EventArgs e)
        {
            bool result;
            int fila = dgvEjemplares.CurrentRow.Index;
            string claveEjemplar = dgvEjemplares[0, fila].Value.ToString();
            DateTime fechaD = new DateTime();
            fechaD = DateTime.Today.AddDays(20);
            EPrestamo prestamo = new EPrestamo($"P{glob.ClavePrestamo}", claveEjemplar,
                txtClave.Text, fechaD);
            try
            {
                result = lnP.registrarPrestamo(prestamo);
                if (result)
                {
                    glob.ClavePrestamo += 1;
                    lnE.actualizarEstadoEjemplar("ES002", claveEjemplar);
                    MessageBox.Show("Préstamo registrado!! Libro préstado exitosamente!!!");
                    btnBuscarUsuario_Click(sender, e);
                    btnEjemplares_Click(sender, e);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
