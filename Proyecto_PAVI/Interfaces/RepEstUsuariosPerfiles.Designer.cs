namespace Proyecto_PAVI.Interfaces
{
    partial class RepEstUsuariosPerfiles
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
            this.reportUP = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportUP
            // 
            this.reportUP.LocalReport.ReportEmbeddedResource = "Proyecto_PAVI.Reportes.graficoUsuariosPerfiles.rdlc";
            this.reportUP.Location = new System.Drawing.Point(12, 35);
            this.reportUP.Name = "reportUP";
            this.reportUP.ServerReport.BearerToken = null;
            this.reportUP.Size = new System.Drawing.Size(776, 392);
            this.reportUP.TabIndex = 1;
            this.reportUP.Load += new System.EventHandler(this.reportUP_Load);
            // 
            // RepEstUsuariosPerfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportUP);
            this.Name = "RepEstUsuariosPerfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepEstUsuariosPerfiles";
            this.Load += new System.EventHandler(this.RepEstUsuariosPerfiles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportUP;
    }
}