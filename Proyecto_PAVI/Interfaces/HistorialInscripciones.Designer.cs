namespace Proyecto_PAVI.Interfaces
{
    partial class HistorialInscripciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialInscripciones));
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.clmIdHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUsuarioResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInscripto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tituloHistorial = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdHistorial,
            this.clmDescripcion,
            this.clmUsuarioResponsable,
            this.clmFecha,
            this.clmInscripto,
            this.clmCurso});
            this.dgvHistorial.Location = new System.Drawing.Point(12, 95);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.Size = new System.Drawing.Size(784, 299);
            this.dgvHistorial.TabIndex = 0;
            // 
            // clmIdHistorial
            // 
            this.clmIdHistorial.DataPropertyName = "id_historial";
            this.clmIdHistorial.HeaderText = "Id_actividad";
            this.clmIdHistorial.Name = "clmIdHistorial";
            this.clmIdHistorial.ReadOnly = true;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmDescripcion.DataPropertyName = "descripcion";
            this.clmDescripcion.HeaderText = "Descripcion";
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            // 
            // clmUsuarioResponsable
            // 
            this.clmUsuarioResponsable.DataPropertyName = "id_responsable";
            this.clmUsuarioResponsable.HeaderText = "Usuario Responsable";
            this.clmUsuarioResponsable.Name = "clmUsuarioResponsable";
            this.clmUsuarioResponsable.ReadOnly = true;
            // 
            // clmFecha
            // 
            this.clmFecha.DataPropertyName = "fecha";
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            // 
            // clmInscripto
            // 
            this.clmInscripto.DataPropertyName = "id_inscripto";
            this.clmInscripto.HeaderText = "Usuario Inscripto";
            this.clmInscripto.Name = "clmInscripto";
            this.clmInscripto.ReadOnly = true;
            // 
            // clmCurso
            // 
            this.clmCurso.DataPropertyName = "id_curso";
            this.clmCurso.HeaderText = "Curso";
            this.clmCurso.Name = "clmCurso";
            this.clmCurso.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(721, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tituloHistorial
            // 
            this.tituloHistorial.AutoSize = true;
            this.tituloHistorial.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.tituloHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloHistorial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloHistorial.Location = new System.Drawing.Point(71, 17);
            this.tituloHistorial.Name = "tituloHistorial";
            this.tituloHistorial.Size = new System.Drawing.Size(207, 22);
            this.tituloHistorial.TabIndex = 62;
            this.tituloHistorial.Text = "Historial Inscripciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(812, 55);
            this.dataGridView1.TabIndex = 60;
            // 
            // HistorialInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.tituloHistorial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvHistorial);
            this.Name = "HistorialInscripciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistorialInscripciones";
            this.Load += new System.EventHandler(this.HistorialInscripciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsuarioResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInscripto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCurso;
        private System.Windows.Forms.Label tituloHistorial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}