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
        ECategoria categoria = new ECategoria("C0001","Comic");

        public frmLibros()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarTextos();
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
            txtClaveAutor.Text = "A0023";
            txtClaveCategoria.Text = categoria.ClaveCategoria;
            txtClaveLibro.Focus();
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
            if(result)
                MessageBox.Show(msj,"Atención",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            return result;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ELibro libro;
            LNLibro ln = new LNLibro(Config.getCadConexion);
            if (textosLlenos())
            {
                libro = new ELibro(txtClaveLibro.Text,
                    txtTituloLibro.Text,
                    txtClaveAutor.Text, categoria,
                    false);
                try
                {
                   
                    if (!ln.libroRepetido(libro))
                    {
                        if (!ln.claveLibroRepetida(libro.ClaveLibro))
                        {
                            if (ln.insertar(libro) > 0)
                            {
                                MessageBox.Show("Guardado con éxito!");
                                //TODO:
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

        private void frmLibros_Load(object sender, EventArgs e)
        {
            llenarDGV();
        }
    }
}
