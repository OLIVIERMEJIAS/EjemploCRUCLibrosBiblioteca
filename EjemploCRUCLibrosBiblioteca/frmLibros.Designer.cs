
namespace EjemploCRUCLibrosBiblioteca
{
    partial class frmLibros
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtClaveLibro = new System.Windows.Forms.TextBox();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaveAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClaveCategoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave del libro";
            // 
            // txtClaveLibro
            // 
            this.txtClaveLibro.Location = new System.Drawing.Point(12, 25);
            this.txtClaveLibro.Name = "txtClaveLibro";
            this.txtClaveLibro.Size = new System.Drawing.Size(100, 20);
            this.txtClaveLibro.TabIndex = 1;
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Location = new System.Drawing.Point(118, 25);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(250, 20);
            this.txtTituloLibro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Título del libro";
            // 
            // txtClaveAutor
            // 
            this.txtClaveAutor.Location = new System.Drawing.Point(374, 25);
            this.txtClaveAutor.Name = "txtClaveAutor";
            this.txtClaveAutor.Size = new System.Drawing.Size(100, 20);
            this.txtClaveAutor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clave del autor";
            // 
            // txtClaveCategoria
            // 
            this.txtClaveCategoria.Location = new System.Drawing.Point(480, 25);
            this.txtClaveCategoria.Name = "txtClaveCategoria";
            this.txtClaveCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtClaveCategoria.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clave de Categoría";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::EjemploCRUCLibrosBiblioteca.Properties.Resources.save__1_;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(224, 51);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 39);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::EjemploCRUCLibrosBiblioteca.Properties.Resources.search_zoom;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(118, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 39);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::EjemploCRUCLibrosBiblioteca.Properties.Resources.New_File;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(12, 51);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 39);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::EjemploCRUCLibrosBiblioteca.Properties.Resources.document_delete__1_;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(330, 51);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 39);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::EjemploCRUCLibrosBiblioteca.Properties.Resources.Gnome_Application_Exit_48__1_;
            this.btnSalir.Location = new System.Drawing.Point(480, 51);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 39);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(564, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // frmLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 334);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtClaveCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClaveAutor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTituloLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClaveLibro);
            this.Controls.Add(this.label1);
            this.Name = "frmLibros";
            this.Text = "Administración de Libros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClaveLibro;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClaveAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClaveCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

