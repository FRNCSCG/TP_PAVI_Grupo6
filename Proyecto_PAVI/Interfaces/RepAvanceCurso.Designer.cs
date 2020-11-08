namespace Proyecto_PAVI.Interfaces
{
    partial class RepAvanceCurso
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
            this.repAvances = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnMostrarTodos2 = new System.Windows.Forms.Button();
            this.btnFiltrar2 = new System.Windows.Forms.Button();
            this.cbCursos2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbInscriptos2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tituloAbmCurso = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // repAvances
            // 
            this.repAvances.LocalReport.ReportEmbeddedResource = "Proyecto_PAVI.Reportes.listadoAvances.rdlc";
            this.repAvances.Location = new System.Drawing.Point(12, 173);
            this.repAvances.Name = "repAvances";
            this.repAvances.ServerReport.BearerToken = null;
            this.repAvances.Size = new System.Drawing.Size(803, 343);
            this.repAvances.TabIndex = 0;
            this.repAvances.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(378, 100);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 13);
            this.lblCantidad.TabIndex = 24;
            // 
            // btnMostrarTodos2
            // 
            this.btnMostrarTodos2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnMostrarTodos2.Location = new System.Drawing.Point(223, 133);
            this.btnMostrarTodos2.Name = "btnMostrarTodos2";
            this.btnMostrarTodos2.Size = new System.Drawing.Size(101, 26);
            this.btnMostrarTodos2.TabIndex = 23;
            this.btnMostrarTodos2.Text = "Mostrar todos";
            this.btnMostrarTodos2.UseVisualStyleBackColor = true;
            this.btnMostrarTodos2.Click += new System.EventHandler(this.btnMostrarTodos2_Click);
            // 
            // btnFiltrar2
            // 
            this.btnFiltrar2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnFiltrar2.Location = new System.Drawing.Point(223, 94);
            this.btnFiltrar2.Name = "btnFiltrar2";
            this.btnFiltrar2.Size = new System.Drawing.Size(101, 25);
            this.btnFiltrar2.TabIndex = 22;
            this.btnFiltrar2.Text = "Filtrar";
            this.btnFiltrar2.UseVisualStyleBackColor = true;
            this.btnFiltrar2.Click += new System.EventHandler(this.btnFiltrar2_Click);
            // 
            // cbCursos2
            // 
            this.cbCursos2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCursos2.FormattingEnabled = true;
            this.cbCursos2.Location = new System.Drawing.Point(73, 133);
            this.cbCursos2.Name = "cbCursos2";
            this.cbCursos2.Size = new System.Drawing.Size(121, 21);
            this.cbCursos2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Curso:";
            // 
            // cbInscriptos2
            // 
            this.cbInscriptos2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInscriptos2.FormattingEnabled = true;
            this.cbInscriptos2.Location = new System.Drawing.Point(73, 97);
            this.cbInscriptos2.Name = "cbInscriptos2";
            this.cbInscriptos2.Size = new System.Drawing.Size(121, 21);
            this.cbInscriptos2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Inscripto:";
            // 
            // tituloAbmCurso
            // 
            this.tituloAbmCurso.AutoSize = true;
            this.tituloAbmCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(143)))));
            this.tituloAbmCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloAbmCurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tituloAbmCurso.Location = new System.Drawing.Point(73, 18);
            this.tituloAbmCurso.Name = "tituloAbmCurso";
            this.tituloAbmCurso.Size = new System.Drawing.Size(186, 22);
            this.tituloAbmCurso.TabIndex = 42;
            this.tituloAbmCurso.Text = "Avances De Cursos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(143)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(827, 64);
            this.dataGridView1.TabIndex = 40;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(143)))));
            this.pictureBox2.Image = global::Proyecto_PAVI.Properties.Resources.lista_de_verificacion;
            this.pictureBox2.Location = new System.Drawing.Point(12, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // RepAvanceCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 528);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tituloAbmCurso);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnMostrarTodos2);
            this.Controls.Add(this.btnFiltrar2);
            this.Controls.Add(this.cbCursos2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbInscriptos2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.repAvances);
            this.Name = "RepAvanceCurso";
            this.Text = "Avances de cursos";
            this.Load += new System.EventHandler(this.RepAvanceCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repAvances;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnMostrarTodos2;
        private System.Windows.Forms.Button btnFiltrar2;
        private System.Windows.Forms.ComboBox cbCursos2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbInscriptos2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tituloAbmCurso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}