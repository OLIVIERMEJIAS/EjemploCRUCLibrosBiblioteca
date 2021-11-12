using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaNegocio;
using System.Data;


namespace EjemploCRUCLibrosBiblioteca
{
    public partial class frmLibros : Form
    {
        LNLibro ln = new LNLibro(Config.getCadConexion);
        ELibro libro;
        public frmLibros()
        {
            InitializeComponent();
        }
        #region MetodosClick
            private void btnNuevo_Click(object sender, EventArgs e)
            {
                limpiarTextos();
            }
          private void btnGuardar_Click(object sender, EventArgs e)
                {
                    EAutor autor;
                    ECategoria cat;
                    
                    LNAutor lnAutor = new LNAutor(Config.getCadConexion);
                    LNCategoria lnCat = new LNCategoria(Config.getCadConexion);
                    if (textosLlenos())
                    {
                        cat = new ECategoria(txtClaveCategoria.Text);
                        libro = new ELibro(txtClaveLibro.Text,
                            txtTituloLibro.Text,
                            txtClaveAutor.Text, cat,
                            false);
                        autor = new EAutor(txtClaveAutor.Text);
                        try
                        {
                   
                            if (!ln.libroRepetido(libro))
                            {
                                if (!ln.claveLibroRepetida(libro.ClaveLibro))
                                {
                                    if (lnAutor.claveAutorExiste(autor.ClaveAutor))
                                    {
                                        if (lnCat.claveCategoriaExiste(cat.ClaveCategoria))
                                        {
                                            if (ln.insertar(libro) > 0)
                                            {
                                                MessageBox.Show("Guardado con éxito!");
                                                //TODO:
                                            }
                                        }
                                        else
                                            MessageBox.Show("La clave de la Categoría ingresada no existe!!");
                                
                                    }
                                    else
                                    {
                                        MessageBox.Show("La clave de autor ingresado no existe!!");
                                    }
                           
                                }
                                else
                                    MessageBox.Show("Esa Clave de libro " +
                                        "ya se encuentra asgnada a otro libro");
                                txtClaveLibro.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Ese título ya existe para el autor " +
                                    "indicado");
                                txtTituloLibro.Focus();
                            }
                        }
                        catch(Exception ex)
                        {
                            mensajeError(ex);
                        }
                    }
                }

        #endregion

        #region MetodosComplementarios

        
        private void llenarDGV(string condicion = "")
        {
            LNLibro ln = new LNLibro(Config.getCadConexion);
            DataSet ds;
            try
            {
                ds = ln.listarTodos(condicion);
                //ds = ln.listarTodos("titulo like %amor%");

                dgvLibros.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {

                mensajeError(ex);
            }

            dgvLibros.Columns[0].HeaderText = "Clave de Libro";
            dgvLibros.Columns[1].HeaderText = "Título";
            dgvLibros.Columns[2].HeaderText = "Clave de Autor";
            dgvLibros.Columns[3].HeaderText = "Clave de Categoría";

            dgvLibros.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void mensajeError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void limpiarTextos()
        {
            txtClaveLibro.Text = string.Empty;
            txtTituloLibro.Text = string.Empty;
            txtClaveAutor.Text = string.Empty;
            txtClaveCategoria.Text = string.Empty;
            libro = null;
            txtClaveLibro.Focus();
            btnEliminar.Enabled = false;
        }

        private bool textosLlenos()
        {
            bool result = false;
            string msj = "";
            if (string.IsNullOrEmpty(txtClaveLibro.Text))
            {
                msj = "Debe agregar una Clave de Libro";
                txtClaveLibro.Focus();
            }
            else if (string.IsNullOrEmpty(txtTituloLibro.Text))
            {
                msj = "Debe agregar un Título de Libro";
                txtTituloLibro.Focus();
            }
            else if (string.IsNullOrEmpty(txtClaveAutor.Text))
            {
                msj = "Debe agregar una Clave de Autor";
                txtClaveAutor.Focus();
            }
            else if (string.IsNullOrEmpty(txtClaveCategoria.Text))
            {
                msj = "Debe agregar una Clave de Categoría";
                txtClaveCategoria.Focus();
            }
            else
                return true;
            if(!result)
                MessageBox.Show(msj,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            return result;
        }

      

        private void frmLibros_Load(object sender, EventArgs e)
        {
            llenarDGV();
        }
        #endregion

        private void dgvLibros_DoubleClick(object sender, EventArgs e)
        {
            int fila = dgvLibros.CurrentRow.Index;
            string clave = dgvLibros[0,fila].Value.ToString();
            string condicion = $"claveLibro='{clave}'";

            try
            {
                libro = ln.buscarRegistro(condicion);

                if (libro != null)
                {
                    txtClaveLibro.Text = libro.ClaveLibro;
                    txtTituloLibro.Text = libro.Titulo;
                    txtClaveAutor.Text = libro.ClaveAutor;
                    txtClaveCategoria.Text =                        libro.Categoria.ClaveCategoria;

                    btnEliminar.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                mensajeError(ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
