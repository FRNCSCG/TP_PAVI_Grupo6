﻿namespace Proyecto_PAVI.Interfaces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Objetivos));
            this.tituloAbmObjetivo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNombreAbrev = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNombreCorto = new System.Windows.Forms.Label();
            this.lblNombreObjetivo = new System.Windows.Forms.Label();
            this.txtNombreLargo = new System.Windows.Forms.TextBox();
            this.lblIdCurso = new System.Windows.Forms.Label();
            this.txtIdObjetivo = new System.Windows.Forms.TextBox();
            this.dgvObjetivos = new System.Windows.Forms.DataGridView();
            this.clmIdCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloAbmObjetivo
            // 
            this.tituloAbmObjetivo.AutoSize = true;
            this.tituloAbmObjetivo.BackColor = System.Drawing.Color.SlateBlue;
            this.tituloAbmObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloAbmObjetivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloAbmObjetivo.Location = new System.Drawing.Point(77, 18);
            this.tituloAbmObjetivo.Name = "tituloAbmObjetivo";
            this.tituloAbmObjetivo.Size = new System.Drawing.Size(141, 22);
            this.tituloAbmObjetivo.TabIndex = 45;
            this.tituloAbmObjetivo.Text = "ABM Objetivos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.BackgroundImage")));
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Location = new System.Drawing.Point(16, 359);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(50, 50);
            this.btnBorrar.TabIndex = 43;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(16, 248);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 42;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Location = new System.Drawing.Point(17, 192);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 41;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(91, 429);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 40;
            this.btnGrabar.Text = "Guardar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(187, 429);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(463, 429);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNombreAbrev
            // 
            this.txtNombreAbrev.Location = new System.Drawing.Point(117, 143);
            this.txtNombreAbrev.Name = "txtNombreAbrev";
            this.txtNombreAbrev.Size = new System.Drawing.Size(190, 20);
            this.txtNombreAbrev.TabIndex = 37;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 55);
            this.dataGridView1.TabIndex = 36;
            // 
            // lblNombreCorto
            // 
            this.lblNombreCorto.AutoSize = true;
            this.lblNombreCorto.Location = new System.Drawing.Point(14, 146);
            this.lblNombreCorto.Name = "lblNombreCorto";
            this.lblNombreCorto.Size = new System.Drawing.Size(97, 13);
            this.lblNombreCorto.TabIndex = 34;
            this.lblNombreCorto.Text = "Nombre abreviado:";
            // 
            // lblNombreObjetivo
            // 
            this.lblNombreObjetivo.AutoSize = true;
            this.lblNombreObjetivo.Location = new System.Drawing.Point(14, 110);
            this.lblNombreObjetivo.Name = "lblNombreObjetivo";
            this.lblNombreObjetivo.Size = new System.Drawing.Size(44, 13);
            this.lblNombreObjetivo.TabIndex = 33;
            this.lblNombreObjetivo.Text = "Nombre";
            // 
            // txtNombreLargo
            // 
            this.txtNombreLargo.Location = new System.Drawing.Point(117, 107);
            this.txtNombreLargo.Name = "txtNombreLargo";
            this.txtNombreLargo.Size = new System.Drawing.Size(190, 20);
            this.txtNombreLargo.TabIndex = 32;
            // 
            // lblIdCurso
            // 
            this.lblIdCurso.AutoSize = true;
            this.lblIdCurso.Location = new System.Drawing.Point(14, 77);
            this.lblIdCurso.Name = "lblIdCurso";
            this.lblIdCurso.Size = new System.Drawing.Size(16, 13);
            this.lblIdCurso.TabIndex = 31;
            this.lblIdCurso.Text = "Id";
            // 
            // txtIdObjetivo
            // 
            this.txtIdObjetivo.Location = new System.Drawing.Point(117, 70);
            this.txtIdObjetivo.Name = "txtIdObjetivo";
            this.txtIdObjetivo.Size = new System.Drawing.Size(190, 20);
            this.txtIdObjetivo.TabIndex = 30;
            // 
            // dgvObjetivos
            // 
            this.dgvObjetivos.AllowUserToAddRows = false;
            this.dgvObjetivos.AllowUserToDeleteRows = false;
            this.dgvObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjetivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdCurso,
            this.clmNombre,
            this.clmCategoria});
            this.dgvObjetivos.Location = new System.Drawing.Point(91, 192);
            this.dgvObjetivos.Name = "dgvObjetivos";
            this.dgvObjetivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjetivos.Size = new System.Drawing.Size(447, 217);
            this.dgvObjetivos.TabIndex = 61;
            this.dgvObjetivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellClick);
            // 
            // clmIdCurso
            // 
            this.clmIdCurso.DataPropertyName = "id_objetivo";
            this.clmIdCurso.HeaderText = "Id ";
            this.clmIdCurso.Name = "clmIdCurso";
            this.clmIdCurso.ReadOnly = true;
            this.clmIdCurso.Width = 50;
            // 
            // clmNombre
            // 
            this.clmNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNombre.DataPropertyName = "nombre_largo";
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmCategoria
            // 
            this.clmCategoria.DataPropertyName = "nombre_corto";
            this.clmCategoria.HeaderText = "Abreviacion";
            this.clmCategoria.MinimumWidth = 8;
            this.clmCategoria.Name = "clmCategoria";
            this.clmCategoria.ReadOnly = true;
            this.clmCategoria.Width = 200;
            // 
            // Objetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 463);
            this.Controls.Add(this.dgvObjetivos);
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
            this.Controls.Add(this.lblNombreCorto);
            this.Controls.Add(this.lblNombreObjetivo);
            this.Controls.Add(this.txtNombreLargo);
            this.Controls.Add(this.lblIdCurso);
            this.Controls.Add(this.txtIdObjetivo);
            this.Name = "Objetivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Objetivo";
            this.Load += new System.EventHandler(this.Objetivo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloAbmObjetivo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNombreAbrev;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNombreCorto;
        private System.Windows.Forms.Label lblNombreObjetivo;
        private System.Windows.Forms.TextBox txtNombreLargo;
        private System.Windows.Forms.Label lblIdCurso;
        private System.Windows.Forms.TextBox txtIdObjetivo;
        private System.Windows.Forms.DataGridView dgvObjetivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategoria;
    }
}