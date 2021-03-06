﻿namespace Proyecto_PAVI.Interfaces
{
    partial class Inscripciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscripciones));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvInscripcion = new System.Windows.Forms.DataGridView();
            this.clmIdCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaVigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFecha = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tituloAbmCurso = new System.Windows.Forms.Label();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPuntuacion = new System.Windows.Forms.ComboBox();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Observacion:";
            // 
            // btnGrabar
            // 
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(90)))), ((int)(((byte)(173)))));
            this.btnGrabar.Location = new System.Drawing.Point(91, 513);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(83, 31);
            this.btnGrabar.TabIndex = 61;
            this.btnGrabar.Text = "Guardar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(90)))), ((int)(((byte)(173)))));
            this.btnCancelar.Location = new System.Drawing.Point(193, 513);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 31);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvInscripcion
            // 
            this.dgvInscripcion.AllowUserToAddRows = false;
            this.dgvInscripcion.AllowUserToDeleteRows = false;
            this.dgvInscripcion.AllowUserToResizeColumns = false;
            this.dgvInscripcion.AllowUserToResizeRows = false;
            this.dgvInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdCurso,
            this.curso,
            this.clmFechaVigencia,
            this.Fin,
            this.clmCategoria,
            this.Observacion});
            this.dgvInscripcion.Location = new System.Drawing.Point(78, 272);
            this.dgvInscripcion.MultiSelect = false;
            this.dgvInscripcion.Name = "dgvInscripcion";
            this.dgvInscripcion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvInscripcion.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInscripcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscripcion.Size = new System.Drawing.Size(730, 222);
            this.dgvInscripcion.TabIndex = 49;
            this.dgvInscripcion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInscripcion_CellClick);
            // 
            // clmIdCurso
            // 
            this.clmIdCurso.DataPropertyName = "id_usuario";
            this.clmIdCurso.HeaderText = "Legajo";
            this.clmIdCurso.Name = "clmIdCurso";
            this.clmIdCurso.ReadOnly = true;
            this.clmIdCurso.Width = 70;
            // 
            // curso
            // 
            this.curso.DataPropertyName = "id_curso";
            this.curso.HeaderText = "Curso";
            this.curso.Name = "curso";
            this.curso.Width = 70;
            // 
            // clmFechaVigencia
            // 
            this.clmFechaVigencia.DataPropertyName = "fecha_inicio";
            this.clmFechaVigencia.FillWeight = 160F;
            this.clmFechaVigencia.HeaderText = "Fecha Inicio";
            this.clmFechaVigencia.Name = "clmFechaVigencia";
            this.clmFechaVigencia.ReadOnly = true;
            this.clmFechaVigencia.Width = 110;
            // 
            // Fin
            // 
            this.Fin.DataPropertyName = "fecha_fin";
            this.Fin.HeaderText = "Fecha fin";
            this.Fin.Name = "Fin";
            this.Fin.Width = 110;
            // 
            // clmCategoria
            // 
            this.clmCategoria.DataPropertyName = "puntuacion";
            this.clmCategoria.HeaderText = "Puntuacion";
            this.clmCategoria.MinimumWidth = 8;
            this.clmCategoria.Name = "clmCategoria";
            this.clmCategoria.ReadOnly = true;
            this.clmCategoria.Width = 65;
            // 
            // Observacion
            // 
            this.Observacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Observacion.DataPropertyName = "observaciones";
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.Name = "Observacion";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 178);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(67, 13);
            this.lblFecha.TabIndex = 47;
            this.lblFecha.Text = "Fecha inicio:";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(30, 92);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(42, 13);
            this.Usuario.TabIndex = 46;
            this.Usuario.Text = "Legajo:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(79, 172);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(211, 20);
            this.dtpFechaInicio.TabIndex = 3;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(523, 135);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(285, 101);
            this.txtObservacion.TabIndex = 6;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(35, 131);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(37, 13);
            this.lblId.TabIndex = 41;
            this.lblId.Text = "Curso:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 64);
            this.dataGridView1.TabIndex = 56;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.BackgroundImage")));
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Location = new System.Drawing.Point(13, 444);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(50, 50);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(13, 328);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Location = new System.Drawing.Point(14, 272);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // tituloAbmCurso
            // 
            this.tituloAbmCurso.AutoSize = true;
            this.tituloAbmCurso.BackColor = System.Drawing.Color.SlateBlue;
            this.tituloAbmCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloAbmCurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloAbmCurso.Location = new System.Drawing.Point(74, 17);
            this.tituloAbmCurso.Name = "tituloAbmCurso";
            this.tituloAbmCurso.Size = new System.Drawing.Size(220, 22);
            this.tituloAbmCurso.TabIndex = 59;
            this.tituloAbmCurso.Text = "Gestionar Inscripciones";
            // 
            // cbCurso
            // 
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(78, 128);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(211, 21);
            this.cbCurso.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Puntuacion:";
            // 
            // cbPuntuacion
            // 
            this.cbPuntuacion.FormattingEnabled = true;
            this.cbPuntuacion.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbPuntuacion.Location = new System.Drawing.Point(523, 92);
            this.cbPuntuacion.Name = "cbPuntuacion";
            this.cbPuntuacion.Size = new System.Drawing.Size(57, 21);
            this.cbPuntuacion.TabIndex = 5;
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(79, 89);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(210, 21);
            this.cbUsuario.TabIndex = 64;
            // 
            // Inscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 567);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.cbPuntuacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.tituloAbmCurso);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvInscripcion);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inscripciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripcion";
            this.Load += new System.EventHandler(this.Estudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvInscripcion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label tituloAbmCurso;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPuntuacion;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaVigencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
    }
}