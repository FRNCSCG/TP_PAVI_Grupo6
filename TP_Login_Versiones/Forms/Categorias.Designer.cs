namespace TP_Login_Versiones.Forms
{
    partial class Categorias
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
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtDescripcionCat = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grdCategorias = new System.Windows.Forms.DataGridView();
            this.clmIdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDescripcionCat = new System.Windows.Forms.Label();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.tituloAbmCategoria = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(90, 425);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 38;
            this.btnGrabar.Text = "Guardar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(186, 425);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(467, 425);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtDescripcionCat
            // 
            this.txtDescripcionCat.Location = new System.Drawing.Point(116, 142);
            this.txtDescripcionCat.Name = "txtDescripcionCat";
            this.txtDescripcionCat.Size = new System.Drawing.Size(228, 20);
            this.txtDescripcionCat.TabIndex = 35;
            this.txtDescripcionCat.TextChanged += new System.EventHandler(this.txtDescripcionCat_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 55);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grdCategorias
            // 
            this.grdCategorias.AllowUserToAddRows = false;
            this.grdCategorias.AllowUserToDeleteRows = false;
            this.grdCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdCategoria,
            this.clmNombre,
            this.clmDescripcion});
            this.grdCategorias.Location = new System.Drawing.Point(90, 188);
            this.grdCategorias.Name = "grdCategorias";
            this.grdCategorias.ReadOnly = true;
            this.grdCategorias.Size = new System.Drawing.Size(452, 217);
            this.grdCategorias.TabIndex = 33;
            this.grdCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategorias_CellContentClick);
            this.grdCategorias.SelectionChanged += new System.EventHandler(this.grdCategorias_SelectionChanged);
            // 
            // clmIdCategoria
            // 
            this.clmIdCategoria.HeaderText = "Id ";
            this.clmIdCategoria.Name = "clmIdCategoria";
            this.clmIdCategoria.ReadOnly = true;
            this.clmIdCategoria.Width = 50;
            // 
            // clmNombre
            // 
            this.clmNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.MinimumWidth = 100;
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.HeaderText = "Descripcion";
            this.clmDescripcion.MinimumWidth = 8;
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            this.clmDescripcion.Width = 200;
            // 
            // lblDescripcionCat
            // 
            this.lblDescripcionCat.AutoSize = true;
            this.lblDescripcionCat.Location = new System.Drawing.Point(13, 142);
            this.lblDescripcionCat.Name = "lblDescripcionCat";
            this.lblDescripcionCat.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionCat.TabIndex = 32;
            this.lblDescripcionCat.Text = "Descripcion:";
            this.lblDescripcionCat.Click += new System.EventHandler(this.lblDescripcionCat_Click);
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Location = new System.Drawing.Point(13, 106);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(44, 13);
            this.lblNombreCategoria.TabIndex = 31;
            this.lblNombreCategoria.Text = "Nombre";
            this.lblNombreCategoria.Click += new System.EventHandler(this.lblNombreCategoria_Click);
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(116, 103);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(228, 20);
            this.txtNombreCategoria.TabIndex = 30;
            this.txtNombreCategoria.TextChanged += new System.EventHandler(this.txtNombreCategoria_TextChanged);
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Location = new System.Drawing.Point(13, 73);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(16, 13);
            this.lblIdCategoria.TabIndex = 29;
            this.lblIdCategoria.Text = "Id";
            this.lblIdCategoria.Click += new System.EventHandler(this.lblIdCategoria_Click);
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(116, 66);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.Size = new System.Drawing.Size(228, 20);
            this.txtIdCategoria.TabIndex = 28;
            this.txtIdCategoria.TextChanged += new System.EventHandler(this.txtIdCategoria_TextChanged);
            // 
            // tituloAbmCategoria
            // 
            this.tituloAbmCategoria.AutoSize = true;
            this.tituloAbmCategoria.BackColor = System.Drawing.Color.SlateBlue;
            this.tituloAbmCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloAbmCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloAbmCategoria.Location = new System.Drawing.Point(72, 19);
            this.tituloAbmCategoria.Name = "tituloAbmCategoria";
            this.tituloAbmCategoria.Size = new System.Drawing.Size(154, 22);
            this.tituloAbmCategoria.TabIndex = 43;
            this.tituloAbmCategoria.Text = "ABM Categorias";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBox1.Image = global::TP_Login_Versiones.Properties.Resources.backend;
            this.pictureBox1.Location = new System.Drawing.Point(16, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::TP_Login_Versiones.Properties.Resources.borrar;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Location = new System.Drawing.Point(16, 355);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(50, 50);
            this.btnBorrar.TabIndex = 41;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::TP_Login_Versiones.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(15, 244);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 40;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::TP_Login_Versiones.Properties.Resources.nuevo;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Location = new System.Drawing.Point(16, 188);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 39;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 459);
            this.Controls.Add(this.tituloAbmCategoria);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtDescripcionCat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grdCategorias);
            this.Controls.Add(this.lblDescripcionCat);
            this.Controls.Add(this.lblNombreCategoria);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.lblIdCategoria);
            this.Controls.Add(this.txtIdCategoria);
            this.Name = "Categorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtDescripcionCat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView grdCategorias;
        private System.Windows.Forms.Label lblDescripcionCat;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tituloAbmCategoria;
    }
}