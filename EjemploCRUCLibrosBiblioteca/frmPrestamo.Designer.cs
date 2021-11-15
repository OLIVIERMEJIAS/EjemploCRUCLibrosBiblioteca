
namespace EjemploCRUCLibrosBiblioteca
{
    partial class frmPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtClave = new System.Windows.Forms.TextBox();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.dgvEjemplares = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnElimPresta = new System.Windows.Forms.Button();
            this.btnPrestarEjemplar = new System.Windows.Forms.Button();
            this.btnEjemplares = new System.Windows.Forms.Button();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.brnDevol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(12, 21);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(148, 20);
            this.txtClave.TabIndex = 0;
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(15, 119);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.Size = new System.Drawing.Size(458, 179);
            this.dgvPrestamos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese Clave de Usuario";
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(519, 119);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.Size = new System.Drawing.Size(458, 179);
            this.dgvLibros.TabIndex = 7;
            // 
            // dgvEjemplares
            // 
            this.dgvEjemplares.AllowUserToAddRows = false;
            this.dgvEjemplares.AllowUserToDeleteRows = false;
            this.dgvEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEjemplares.Location = new System.Drawing.Point(519, 364);
            this.dgvEjemplares.Name = "dgvEjemplares";
            this.dgvEjemplares.ReadOnly = true;
            this.dgvEjemplares.Size = new System.Drawing.Size(458, 141);
            this.dgvEjemplares.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre Completo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(15, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(458, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Préstamos de Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ingrese Nombre de Libro";
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(519, 66);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(458, 20);
            this.txtNombreLibro.TabIndex = 13;
            this.txtNombreLibro.TextChanged += new System.EventHandler(this.txtNombreLibro_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(662, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Libros Resultantes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EjemploCRUCLibrosBiblioteca.Properties.Resources.emblem_library;
            this.pictureBox1.Location = new System.Drawing.Point(170, 363);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnElimPresta
            // 
            this.btnElimPresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElimPresta.Image = global::EjemploCRUCLibrosBiblioteca.Properties.Resources.folder_delete;
            this.btnElimPresta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElimPresta.Location = new System.Drawing.Point(228, 304);
            this.btnElimPresta.Name = "btnElimPresta";
            this.btnElimPresta.Size = new System.Drawing.Size(245, 53);
            this.btnElimPresta.TabIndex = 19;
            this.btnElimPresta.Text = "Eliminar Préstamo";
            this.btnElimPresta.UseVisualStyleBackColor = true;
            this.btnElimPresta.Click += new System.EventHandler(this.btnElimPresta_Click);
            // 
            // btnPrestarEjemplar
            // 
            this.btnPrestarEjemplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestarEjemplar.Image = global::EjemploCRUCLibrosBiblioteca.Properties.Resources.book_folder;
            this.btnPrestarEjemplar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestarEjemplar.Location = new System.Drawing.Point(762, 303);
            this.btnPrestarEjemplar.Name = "btnPrestarEjemplar";
            this.btnPrestarEjemplar.Size = new System.Drawing.Size(198, 54);
            this.btnPrestarEjemplar.TabIndex = 17;
            this.btnPrestarEjemplar.Text = "Prestar Ejemplar";
            this.btnPrestarEjemplar.UseVisualStyleBackColor = true;
            this.btnPrestarEjemplar.Click += new System.EventHandler(this.btnPrestarEjemplar_Click);
            // 
            // btnEjemplares
            // 
            this.btnEjemplares.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjemplares.Image = global::EjemploCRUCLibrosBiblioteca.Properties.Resources.BeOS_Help_book__1_;
            this.btnEjemplares.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEjemplares.Location = new System.Drawing.Point(543, 304);
            this.btnEjemplares.Name = "btnEjemplares";
            this.btnEjemplares.Size = new System.Drawing.Size(198, 54);
            this.btnEjemplares.TabIndex = 9;
            this.btnEjemplares.Text = "Buscar Ejemplares Disponibles";
            this.btnEjemplares.UseVisualStyleBackColor = true;
            this.btnEjemplares.Click += new System.EventHandler(this.btnEjemplares_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.Image = global::EjemploCRUCLibrosBiblioteca.Properties.Resources.human_folder_saved_search__1_;
            this.btnBuscarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(170, 12);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(135, 34);
            this.btnBuscarUsuario.TabIndex = 6;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // brnDevol
            // 
            this.brnDevol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnDevol.Image = global::EjemploCRUCLibrosBiblioteca.Properties.Resources.Address_Book__1_;
            this.brnDevol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.brnDevol.Location = new System.Drawing.Point(12, 303);
            this.brnDevol.Name = "brnDevol";
            this.brnDevol.Size = new System.Drawing.Size(210, 54);
            this.brnDevol.TabIndex = 3;
            this.brnDevol.Text = "Devolver Libro";
            this.brnDevol.UseVisualStyleBackColor = true;
            this.brnDevol.Click += new System.EventHandler(this.brnDevol_Click);
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 505);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnElimPresta);
            this.Controls.Add(this.btnPrestarEjemplar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreLibro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnEjemplares);
            this.Controls.Add(this.dgvEjemplares);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.brnDevol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.txtClave);
            this.Name = "frmPrestamo";
            this.Text = "Préstamo y Devolución de Libros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brnDevol;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridView dgvEjemplares;
        private System.Windows.Forms.Button btnEjemplares;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrestarEjemplar;
        private System.Windows.Forms.Button btnElimPresta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}