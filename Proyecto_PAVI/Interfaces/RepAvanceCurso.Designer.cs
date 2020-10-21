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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // repAvances
            // 
            this.repAvances.LocalReport.ReportEmbeddedResource = "Proyecto_PAVI.Reportes.listadoAvances.rdlc";
            this.repAvances.Location = new System.Drawing.Point(12, 118);
            this.repAvances.Name = "repAvances";
            this.repAvances.ServerReport.BearerToken = null;
            this.repAvances.Size = new System.Drawing.Size(740, 253);
            this.repAvances.TabIndex = 0;
            this.repAvances.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(378, 70);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 13);
            this.lblCantidad.TabIndex = 24;
            // 
            // btnMostrarTodos2
            // 
            this.btnMostrarTodos2.Location = new System.Drawing.Point(245, 63);
            this.btnMostrarTodos2.Name = "btnMostrarTodos2";
            this.btnMostrarTodos2.Size = new System.Drawing.Size(101, 26);
            this.btnMostrarTodos2.TabIndex = 23;
            this.btnMostrarTodos2.Text = "Mostrar todos";
            this.btnMostrarTodos2.UseVisualStyleBackColor = true;
            this.btnMostrarTodos2.Click += new System.EventHandler(this.btnMostrarTodos2_Click);
            // 
            // btnFiltrar2
            // 
            this.btnFiltrar2.Location = new System.Drawing.Point(245, 24);
            this.btnFiltrar2.Name = "btnFiltrar2";
            this.btnFiltrar2.Size = new System.Drawing.Size(101, 25);
            this.btnFiltrar2.TabIndex = 22;
            this.btnFiltrar2.Text = "Filtrar";
            this.btnFiltrar2.UseVisualStyleBackColor = true;
            this.btnFiltrar2.Click += new System.EventHandler(this.btnFiltrar2_Click);
            // 
            // cbCursos2
            // 
            this.cbCursos2.FormattingEnabled = true;
            this.cbCursos2.Location = new System.Drawing.Point(95, 63);
            this.cbCursos2.Name = "cbCursos2";
            this.cbCursos2.Size = new System.Drawing.Size(121, 21);
            this.cbCursos2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Curso:";
            // 
            // cbInscriptos2
            // 
            this.cbInscriptos2.FormattingEnabled = true;
            this.cbInscriptos2.Location = new System.Drawing.Point(95, 27);
            this.cbInscriptos2.Name = "cbInscriptos2";
            this.cbInscriptos2.Size = new System.Drawing.Size(121, 21);
            this.cbInscriptos2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Inscripto:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 26);
            this.button1.TabIndex = 25;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RepAvanceCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 411);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}