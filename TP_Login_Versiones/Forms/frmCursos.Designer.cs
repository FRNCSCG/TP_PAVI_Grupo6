namespace TP_Login_Versiones.Forms
{
    partial class frmCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCursos));
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.tituloAbmCurso = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dtpFechaVigencia = new System.Windows.Forms.DateTimePicker();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdCursos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clmIdCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaVigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Location = new System.Drawing.Point(96, 83);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(282, 20);
            this.txtIdCurso.TabIndex = 0;
            // 
            // tituloAbmCurso
            // 
            this.tituloAbmCurso.AutoSize = true;
            this.tituloAbmCurso.BackColor = System.Drawing.Color.SlateBlue;
            this.tituloAbmCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloAbmCurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloAbmCurso.Location = new System.Drawing.Point(73, 18);
            this.tituloAbmCurso.Name = "tituloAbmCurso";
            this.tituloAbmCurso.Size = new System.Drawing.Size(120, 22);
            this.tituloAbmCurso.TabIndex = 1;
            this.tituloAbmCurso.Text = "ABM Cursos";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(9, 86);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(60, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id de curso";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 129);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(282, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(528, 99);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(382, 144);
            this.txtDescripcion.TabIndex = 5;
            // 
            // dtpFechaVigencia
            // 
            this.dtpFechaVigencia.Location = new System.Drawing.Point(96, 174);
            this.dtpFechaVigencia.Name = "dtpFechaVigencia";
            this.dtpFechaVigencia.Size = new System.Drawing.Size(282, 20);
            this.dtpFechaVigencia.TabIndex = 6;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(96, 222);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(282, 21);
            this.cboCategoria.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 132);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(9, 180);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(81, 13);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha Vigencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Categoría";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Descripción";
            // 
            // grdCursos
            // 
            this.grdCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdCurso,
            this.clmNombre,
            this.clmCategoria,
            this.clmFechaVigencia});
            this.grdCursos.Location = new System.Drawing.Point(77, 273);
            this.grdCursos.Name = "grdCursos";
            this.grdCursos.Size = new System.Drawing.Size(833, 217);
            this.grdCursos.TabIndex = 12;
            this.grdCursos.SelectionChanged += new System.EventHandler(this.grdCursos_SelectionChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(835, 510);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(170, 510);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(77, 510);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 15;
            this.btnGrabar.Text = "Guardar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::TP_Login_Versiones.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(12, 329);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::TP_Login_Versiones.Properties.Resources.borrar;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Location = new System.Drawing.Point(12, 440);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(50, 50);
            this.btnBorrar.TabIndex = 18;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::TP_Login_Versiones.Properties.Resources.nuevo;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Location = new System.Drawing.Point(13, 273);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // clmIdCurso
            // 
            this.clmIdCurso.HeaderText = "Id Curso";
            this.clmIdCurso.Name = "clmIdCurso";
            // 
            // clmNombre
            // 
            this.clmNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            // 
            // clmCategoria
            // 
            this.clmCategoria.HeaderText = "Categoría";
            this.clmCategoria.MinimumWidth = 8;
            this.clmCategoria.Name = "clmCategoria";
            this.clmCategoria.Width = 200;
            // 
            // clmFechaVigencia
            // 
            this.clmFechaVigencia.FillWeight = 160F;
            this.clmFechaVigencia.HeaderText = "Fecha Vigencia";
            this.clmFechaVigencia.Name = "clmFechaVigencia";
            this.clmFechaVigencia.Width = 160;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(927, 55);
            this.dataGridView1.TabIndex = 19;
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 554);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grdCursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.dtpFechaVigencia);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tituloAbmCurso);
            this.Controls.Add(this.txtIdCurso);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.frmCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdCurso;
        private System.Windows.Forms.Label tituloAbmCurso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaVigencia;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdCursos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaVigencia;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}