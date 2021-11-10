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
            LNLibro ln = new LNLibro();
            if (textosLlenos())
            {
                libro = new ELibro(txtClaveLibro.Text,
                    txtTituloLibro.Text,
                    txtClaveAutor.Text, categoria,
                    false);
                try
                {
                    //TODO: AGREGAR ACCESO A CAPA DE LOGICA
                    if (!ln.libroRepetido(libro))
                    {
                        if (!ln.claveLibroRepetida(libro.ClaveLibro))
                        {

                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
                }
            }
        }
    }
}
