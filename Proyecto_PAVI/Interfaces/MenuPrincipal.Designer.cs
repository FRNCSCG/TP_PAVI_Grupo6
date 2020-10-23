namespace Proyecto_PAVI.Interfaces
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosPorCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilesDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadUsuariosPorCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.puntuacionUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuToolStripMenuItem,
            this.estudiantesToolStripMenuItem,
            this.objetivosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuToolStripMenuItem
            // 
            this.cuToolStripMenuItem.Name = "cuToolStripMenuItem";
            this.cuToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cuToolStripMenuItem.Text = "Cursos";
            this.cuToolStripMenuItem.Click += new System.EventHandler(this.cuToolStripMenuItem_Click);
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.ShowShortcutKeys = false;
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.estudiantesToolStripMenuItem.Text = "Inscripciones";
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.gestionarToolStripMenuItem.Text = "Gestionar";
            this.gestionarToolStripMenuItem.Click += new System.EventHandler(this.gestionarToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // objetivosToolStripMenuItem
            // 
            this.objetivosToolStripMenuItem.Name = "objetivosToolStripMenuItem";
            this.objetivosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.objetivosToolStripMenuItem.Text = "Objetivos";
            this.objetivosToolStripMenuItem.Click += new System.EventHandler(this.objetivosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscripcionesToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.usuariosPorCursoToolStripMenuItem,
            this.perfilesDeUsuarioToolStripMenuItem,
            this.cantidadUsuariosPorCursoToolStripMenuItem,
            this.puntuacionUsuariosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // inscripcionesToolStripMenuItem
            // 
            this.inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            this.inscripcionesToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.inscripcionesToolStripMenuItem.Text = "Inscripciones";
            this.inscripcionesToolStripMenuItem.Click += new System.EventHandler(this.inscripcionesToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.cursosToolStripMenuItem.Text = "Avances de curso";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // usuariosPorCursoToolStripMenuItem
            // 
            this.usuariosPorCursoToolStripMenuItem.Name = "usuariosPorCursoToolStripMenuItem";
            this.usuariosPorCursoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.usuariosPorCursoToolStripMenuItem.Text = "Usuarios por curso";
            this.usuariosPorCursoToolStripMenuItem.Click += new System.EventHandler(this.usuariosPorCursoToolStripMenuItem_Click);
            // 
            // perfilesDeUsuarioToolStripMenuItem
            // 
            this.perfilesDeUsuarioToolStripMenuItem.Name = "perfilesDeUsuarioToolStripMenuItem";
            this.perfilesDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.perfilesDeUsuarioToolStripMenuItem.Text = "Perfiles de Usuario";
            this.perfilesDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.perfilesDeUsuarioToolStripMenuItem_Click);
            // 
            // cantidadUsuariosPorCursoToolStripMenuItem
            // 
            this.cantidadUsuariosPorCursoToolStripMenuItem.Name = "cantidadUsuariosPorCursoToolStripMenuItem";
            this.cantidadUsuariosPorCursoToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.cantidadUsuariosPorCursoToolStripMenuItem.Text = "Cantidad Usuarios por Curso";
            this.cantidadUsuariosPorCursoToolStripMenuItem.Click += new System.EventHandler(this.cantidadUsuariosPorCursoToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 239);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.SeaGreen;
            this.lblBienvenido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(254, 320);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(65, 25);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "label1";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // puntuacionUsuariosToolStripMenuItem
            // 
            this.puntuacionUsuariosToolStripMenuItem.Name = "puntuacionUsuariosToolStripMenuItem";
            this.puntuacionUsuariosToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.puntuacionUsuariosToolStripMenuItem.Text = "Puntuacion Usuarios";
            this.puntuacionUsuariosToolStripMenuItem.Click += new System.EventHandler(this.puntuacionUsuariosToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 552);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de cursos";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosPorCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem cantidadUsuariosPorCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntuacionUsuariosToolStripMenuItem;
    }
}