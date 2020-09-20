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
            this.lblNombreCorto = new System.Windows.Forms.Label();
            this.lblNombreObjetivo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblIdCurso = new System.Windows.Forms.Label();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.clmIdObjetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreAbrev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdObjetivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.grdObjetivos.Location = new System.Drawing.Point(89, 182);
            this.grdObjetivos.Name = "grdObjetivos";
            this.grdObjetivos.ReadOnly = true;
            this.grdObjetivos.Size = new System.Drawing.Size(362, 217);
            this.grdObjetivos.TabIndex = 19;
            // 
            // lblNombreCorto
            // 
            this.lblNombreCorto.AutoSize = true;
            this.lblNombreCorto.Location = new System.Drawing.Point(12, 136);
            this.lblNombreCorto.Name = "lblNombreCorto";
            this.lblNombreCorto.Size = new System.Drawing.Size(97, 13);
            this.lblNombreCorto.TabIndex = 18;
            this.lblNombreCorto.Text = "Nombre abreviado:";
            // 
            // lblNombreObjetivo
            // 
            this.lblNombreObjetivo.AutoSize = true;
            this.lblNombreObjetivo.Location = new System.Drawing.Point(12, 100);
            this.lblNombreObjetivo.Name = "lblNombreObjetivo";
            this.lblNombreObjetivo.Size = new System.Drawing.Size(44, 13);
            this.lblNombreObjetivo.TabIndex = 17;
            this.lblNombreObjetivo.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(62, 97);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // lblIdCurso
            // 
            this.lblIdCurso.AutoSize = true;
            this.lblIdCurso.Location = new System.Drawing.Point(12, 63);
            this.lblIdCurso.Name = "lblIdCurso";
            this.lblIdCurso.Size = new System.Drawing.Size(16, 13);
            this.lblIdCurso.TabIndex = 14;
            this.lblIdCurso.Text = "Id";
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Location = new System.Drawing.Point(34, 60);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(157, 20);
            this.txtIdCurso.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 55);
            this.dataGridView1.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 21;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::TP_Login_Versiones.Properties.Resources.borrar;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Location = new System.Drawing.Point(14, 349);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(50, 50);
            this.btnBorrar.TabIndex = 27;
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::TP_Login_Versiones.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(14, 238);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(50, 50);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::TP_Login_Versiones.Properties.Resources.nuevo;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Location = new System.Drawing.Point(15, 182);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(89, 419);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 24;
            this.btnGrabar.Text = "Guardar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(185, 419);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(376, 419);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
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
            // Objetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 459);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grdObjetivos);
            this.Controls.Add(this.lblNombreCorto);
            this.Controls.Add(this.lblNombreObjetivo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblIdCurso);
            this.Controls.Add(this.txtIdCurso);
            this.Name = "Objetivos";
            this.Text = "Objetivos";
            this.Load += new System.EventHandler(this.Objetivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdObjetivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdObjetivos;
        private System.Windows.Forms.Label lblNombreCorto;
        private System.Windows.Forms.Label lblNombreObjetivo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblIdCurso;
        private System.Windows.Forms.TextBox txtIdCurso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdObjetivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreAbrev;
    }
}