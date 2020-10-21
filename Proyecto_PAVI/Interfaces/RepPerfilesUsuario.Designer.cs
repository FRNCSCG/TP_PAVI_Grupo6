namespace Proyecto_PAVI.Interfaces
{
    partial class RepPerfilesUsuario
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
            this.components = new System.ComponentModel.Container();
            this.reportPU = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbPerfiles = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCantidadRegistros = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.database = new Proyecto_PAVI.Database();
            this.perfilesUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfilesUsuariosTableAdapter = new Proyecto_PAVI.DatabaseTableAdapters.PerfilesUsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportPU
            // 
            this.reportPU.LocalReport.ReportEmbeddedResource = "Proyecto_PAVI.Reportes.reportePerfilesUsuario.rdlc";
            this.reportPU.Location = new System.Drawing.Point(15, 75);
            this.reportPU.Name = "reportPU";
            this.reportPU.ServerReport.BearerToken = null;
            this.reportPU.Size = new System.Drawing.Size(659, 331);
            this.reportPU.TabIndex = 0;
            this.reportPU.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // cbPerfiles
            // 
            this.cbPerfiles.FormattingEnabled = true;
            this.cbPerfiles.Location = new System.Drawing.Point(75, 17);
            this.cbPerfiles.Name = "cbPerfiles";
            this.cbPerfiles.Size = new System.Drawing.Size(121, 21);
            this.cbPerfiles.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Perfil:";
            // 
            // lblCantidadRegistros
            // 
            this.lblCantidadRegistros.AutoSize = true;
            this.lblCantidadRegistros.Location = new System.Drawing.Point(560, 20);
            this.lblCantidadRegistros.Name = "lblCantidadRegistros";
            this.lblCantidadRegistros.Size = new System.Drawing.Size(0, 13);
            this.lblCantidadRegistros.TabIndex = 28;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(484, 13);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(101, 27);
            this.btnFiltrar.TabIndex = 27;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(481, 59);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(59, 13);
            this.lblCantidad.TabIndex = 30;
            this.lblCantidad.Text = "lblCantidad";
            // 
            // database
            // 
            this.database.DataSetName = "Database";
            this.database.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // perfilesUsuariosBindingSource
            // 
            this.perfilesUsuariosBindingSource.DataMember = "PerfilesUsuarios";
            this.perfilesUsuariosBindingSource.DataSource = this.database;
            // 
            // perfilesUsuariosTableAdapter
            // 
            this.perfilesUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // RepPerfilesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 424);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCantidadRegistros);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cbPerfiles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reportPU);
            this.Name = "RepPerfilesUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepPerfilesUsuario";
            this.Load += new System.EventHandler(this.RepPerfilesUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportPU;
        private System.Windows.Forms.ComboBox cbPerfiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCantidadRegistros;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblCantidad;
        private Database database;
        private System.Windows.Forms.BindingSource perfilesUsuariosBindingSource;
        private DatabaseTableAdapters.PerfilesUsuariosTableAdapter perfilesUsuariosTableAdapter;
    }
}