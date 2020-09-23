namespace TP_Login_Versiones.Forms
{
    partial class Objetivos
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
            this.grdObjetivos = new System.Windows.Forms.DataGridView();
            this.clmIdObjetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreAbrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombreCorto = new System.Windows.Forms.Label();
            this.lblNombreObjetivo = new System.Windows.Forms.Label();
            this.txtNombreLargo = new System.Windows.Forms.TextBox();
            this.lblIdCurso = new System.Windows.Forms.Label();
            this.txtIdObjetivo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNombreAbrev = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tituloAbmObjetivo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdObjetivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdObjetivos
            // 
            this.grdObjetivos.AllowUserToAddRows = false;
            this.grdObjetivos.AllowUserToDeleteRows = false;
            this.grdObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdObjetivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdObjetivo,
            this.clmNombre,
            this.clmNombreAbrev});
            this.grdObjetivos.Location = new System.Drawing.Point(87, 192);
            this.grdObjetivos.Name = "grdObjetivos";
            this.grdObjetivos.ReadOnly = true;
            this.grdObjetivos.Size = new System.Drawing.Size(452, 217);
            this.grdObjetivos.TabIndex = 19;
            this.grdObjetivos.SelectionChanged += new System.EventHandler(this.grdObjetivos_SelectionChanged);
            // 
            // clmIdObjetivo
            // 
            this.clmIdObjetivo.HeaderText = "Id ";
            this.clmIdObjetivo.Name = "clmIdObjetivo";
            this.clmIdObjetivo.ReadOnly = true;
            this.clmIdObjetivo.Width = 50;
            // 
            // clmNombre
            // 
            this.clmNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.MinimumWidth = 100;
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmNombreAbrev
            // 
            this.clmNombreAbrev.HeaderText = "Nombre abrev.";
            this.clmNombreAbrev.MinimumWidth = 8;
            this.clmNombreAbrev.Name = "clmNombreAbrev";
            this.clmNombreAbrev.ReadOnly = true;
            this.clmNombreAbrev.Width = 200;
            // 
            // lblNombreCorto
            // 
            this.lblNombreCorto.AutoSize = true;
            this.lblNombreCorto.Location = new System.Drawing.Point(10, 146);
            this.lblNombreCorto.Name = "lblNombreCorto";
            this.lblNombreCorto.Size = new System.Drawing.Size(97, 13);
            this.lblNombreCorto.TabIndex = 18;
            this.lblNombreCorto.Text = "Nombre abreviado:";
            // 
            // lblNombreObjetivo
            // 
            this.lblNombreObjetivo.AutoSize = true;
            this.lblNombreObjetivo.Location = new System.Drawing.Point(10, 110);
            this.lblNombreObjetivo.Name = "lblNombreObjetivo";
            this.lblNombreObjetivo.Size = new System.Drawing.Size(44, 13);
            this.lblNombreObjetivo.TabIndex = 17;
            this.lblNombreObjetivo.Text = "Nombre";
            // 
            // txtNombreLargo
            // 
            this.txtNombreLargo.Location = new System.Drawing.Point(113, 107);
            this.txtNombreLargo.Name = "txtNombreLargo";
            this.txtNombreLargo.Size = new System.Drawing.Size(190, 20);
            this.txtNombreLargo.TabIndex = 15;
            // 
            // lblIdCurso
            // 
            this.lblIdCurso.AutoSize = true;
            this.lblIdCurso.Location = new System.Drawing.Point(10, 77);
            this.lblIdCurso.Name = "lblIdCurso";
            this.lblIdCurso.Size = new System.Drawing.Size(16, 13);
            this.lblIdCurso.TabIndex = 14;
            this.lblIdCurso.Text = "Id";
            // 
            // txtIdObjetivo
            // 
            this.txtIdObjetivo.Location = new System.Drawing.Point(113, 70);
            this.txtIdObjetivo.Name = "txtIdObjetivo";
            this.txtIdObjetivo.Size = new System.Drawing.Size(190, 20);
            this.txtIdObjetivo.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 55);
            this.dataGridView1.TabIndex = 20;
            // 
            // txtNombreAbrev
            // 
            this.txtNombreAbrev.Location = new System.Drawing.Point(113, 143);
            this.txtNombreAbrev.Name = "txtNombreAbrev";
            this.txtNombreAbrev.Size = new System.Drawing.Size(190, 20);
            this.txtNombreAbrev.TabIndex = 21;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(87, 429);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 24;
            this.btnGrabar.Text = "Guardar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(183, 429);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(464, 429);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tituloAbmObjetivo
            // 
            this.tituloAbmObjetivo.AutoSize = true;
            this.tituloAbmObjetivo.BackColor = System.Drawing.Color.SlateBlue;
            this.tituloAbmObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloAbmObjetivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloAbmObjetivo.Location = new System.Drawing.Point(73, 18);
            this.tituloAbmObjetivo.Name = "tituloAbmObjetivo";
            this.tituloAbmObjetivo.Size = new System.Drawing.Size(141, 22);
            this.tituloAbmObjetivo.TabIndex = 29;
            this.tituloAbmObjetivo.Text = "ABM Objetivos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBox1.Image = global::TP_Login_Versiones.Properties.Resources.telefono_movil;
            this.pictureBox1.Location = new System.Drawing.Point(16, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::TP_Login_Versiones.Properties.Resources.borrar;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Location = new System.Drawing.Point(12, 359);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(50, 50);
            this.btnBorrar.TabIndex = 27;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::TP_Login_Versiones.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(12, 248);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::TP_Login_Versiones.Properties.Resources.nuevo;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Location = new System.Drawing.Point(13, 192);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Objetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 459);
            this.Controls.Add(this.tituloAbmObjetivo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtNombreAbrev);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grdObjetivos);
            this.Controls.Add(this.lblNombreCorto);
            this.Controls.Add(this.lblNombreObjetivo);
            this.Controls.Add(this.txtNombreLargo);
            this.Controls.Add(this.lblIdCurso);
            this.Controls.Add(this.txtIdObjetivo);
            this.Name = "Objetivos";
            this.Text = "Objetivos";
            this.Load += new System.EventHandler(this.Objetivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdObjetivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdObjetivos;
        private System.Windows.Forms.Label lblNombreCorto;
        private System.Windows.Forms.Label lblNombreObjetivo;
        private System.Windows.Forms.TextBox txtNombreLargo;
        private System.Windows.Forms.Label lblIdCurso;
        private System.Windows.Forms.TextBox txtIdObjetivo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombreAbrev;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdObjetivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreAbrev;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tituloAbmObjetivo;
    }
}