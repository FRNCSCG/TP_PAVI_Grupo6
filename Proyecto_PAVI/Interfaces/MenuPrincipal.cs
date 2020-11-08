using Proyecto_PAVI.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_PAVI.Interfaces
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            Visibles();
        }


        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            if (Login.ban==false)                
            {
                Login pantLogin = new Login();
                pantLogin.ShowDialog();
                Login.ban = true;
                
                lblBienv.Text="Bienvenido " + Login.usuarioActual + "!";

            }      

        }

        private void Visibles()
        {
            panelEstadisticas.Visible = false;
            panelListados.Visible = false;
            pnlGestionar.Visible = true;

            
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            if (pnlGestionar.Visible==false)
            {
                pnlGestionar.Visible = true;
            }
            else
            {
                pnlGestionar.Visible = false;
            }
        }

        private void btnListados_Click(object sender, EventArgs e)
        {
            if (panelListados.Visible == false)
            {
                panelListados.Visible = true;
            }
            else
            {
                panelListados.Visible = false;
            }
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            if (panelEstadisticas.Visible == false)
            {
                panelEstadisticas.Visible = true;
            }
            else
            {
                panelEstadisticas.Visible = false;
            }
        }



        private void clearPanel()
        {
            for (int i = panelContainer.Controls.Count - 1; i >= 0; i--)
            {
                panelContainer.Controls[i].Dispose();
            }
        }

        private void btnABMins_Click(object sender, EventArgs e)
        {
            clearPanel();
            Inscripciones pantActual = new Inscripciones() { TopLevel = false, TopMost = true };
            pantActual.FormBorderStyle = FormBorderStyle.None;
            pantActual.ForeColor = System.Drawing.Color.White;
            pantActual.BackColor = Color.FromArgb(5, 8, 13);
            this.panelContainer.Controls.Add(pantActual);
            pantActual.Show();
       


        }

        private void btnABMcursos_Click(object sender, EventArgs e)
        {
            clearPanel();
            Cursos pantActual = new Cursos() { TopLevel = false, TopMost = true };
            pantActual.FormBorderStyle = FormBorderStyle.None;
            pantActual.ForeColor = System.Drawing.Color.White;
            pantActual.BackColor = Color.FromArgb(5, 8, 13);
            this.panelContainer.Controls.Add(pantActual);
            pantActual.Show();
        }

        private void btnABMcat_Click(object sender, EventArgs e)
        {
            clearPanel();
            Categorias pantActual = new Categorias() { TopLevel = false, TopMost = true };
            pantActual.FormBorderStyle = FormBorderStyle.None;
            pantActual.ForeColor = System.Drawing.Color.White;
            pantActual.BackColor = Color.FromArgb(5, 8, 13);
            this.panelContainer.Controls.Add(pantActual);
            pantActual.Show();
        }

        private void btnABMobj_Click(object sender, EventArgs e)
        {
            clearPanel();
            Objetivos pantActual = new Objetivos() { TopLevel = false, TopMost = true };
            pantActual.FormBorderStyle = FormBorderStyle.None;
            pantActual.ForeColor = System.Drawing.Color.White;
            pantActual.BackColor = Color.FromArgb(5, 8, 13);
            this.panelContainer.Controls.Add(pantActual);
            pantActual.Show();
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            clearPanel();
            RepEstUsuariosCursos pantActual = new RepEstUsuariosCursos() { TopLevel = false, TopMost = true };
            pantActual.FormBorderStyle = FormBorderStyle.None;
            pantActual.ForeColor = System.Drawing.Color.White;
            pantActual.BackColor = Color.FromArgb(5, 8, 13);
            this.panelContainer.Controls.Add(pantActual);
            pantActual.Show();
        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            clearPanel();
            RepEstPuntuacionUsuarios pantActual = new RepEstPuntuacionUsuarios() { TopLevel = false, TopMost = true };
            pantActual.FormBorderStyle = FormBorderStyle.None;
            pantActual.ForeColor = System.Drawing.Color.White;
            pantActual.BackColor = Color.FromArgb(5, 8, 13);
            this.panelContainer.Controls.Add(pantActual);
            pantActual.Show();
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            clearPanel();
            RepEstUsuariosPerfiles pantActual = new RepEstUsuariosPerfiles() { TopLevel = false, TopMost = true };
            pantActual.FormBorderStyle = FormBorderStyle.None;
            pantActual.ForeColor = System.Drawing.Color.White;
            pantActual.BackColor = Color.FromArgb(5, 8, 13);
            this.panelContainer.Controls.Add(pantActual);
            pantActual.Show();
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            clearPanel();
            RepEstActividadesInscripciones pantActual = new RepEstActividadesInscripciones() { TopLevel = false, TopMost = true };
            pantActual.FormBorderStyle = FormBorderStyle.None;
            pantActual.ForeColor = System.Drawing.Color.White;
            pantActual.BackColor = Color.FromArgb(5, 8, 13);
            this.panelContainer.Controls.Add(pantActual);
            pantActual.Show();
        }

        private void btnL1_Click(object sender, EventArgs e)
        {
            clearPanel();
            RepInscripciones pantActual = new RepInscripciones() { TopLevel = false, TopMost = true };
            pantActual.FormBorderStyle = FormBorderStyle.None;
            pantActual.ForeColor = System.Drawing.Color.White;
            pantActual.BackColor = Color.FromArgb(5, 8, 13);
            this.panelContainer.Controls.Add(pantActual);
            pantActual.Show();
        }

        private void btnL2_Click(object sender, EventArgs e)
        {
            clearPanel();
            RepPerfilesUsuario pantActual = new RepPerfilesUsuario() { TopLevel = false, TopMost = true };
            pantActual.FormBorderStyle = FormBorderStyle.None;
            pantActual.ForeColor = System.Drawing.Color.White;
            pantActual.BackColor = Color.FromArgb(5, 8, 13);
            this.panelContainer.Controls.Add(pantActual);
            pantActual.Show();
        }

        private void btnL3_Click(object sender, EventArgs e)
        {
            clearPanel();
            RepUsuariosXCurso pantActual = new RepUsuariosXCurso() { TopLevel = false, TopMost = true };
            pantActual.FormBorderStyle = FormBorderStyle.None;
            pantActual.ForeColor = System.Drawing.Color.White;
            pantActual.BackColor = Color.FromArgb(5, 8, 13);
            this.panelContainer.Controls.Add(pantActual);
            pantActual.Show();
        }

        private void btnL4_Click(object sender, EventArgs e)
        {
            clearPanel();
            RepAvanceCurso pantActual = new RepAvanceCurso() { TopLevel = false, TopMost = true };
            pantActual.FormBorderStyle = FormBorderStyle.None;
            pantActual.ForeColor = System.Drawing.Color.White;
            pantActual.BackColor = Color.FromArgb(5, 8, 13);
            this.panelContainer.Controls.Add(pantActual);
            pantActual.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearPanel();
            HistorialInscripciones pantActual = new HistorialInscripciones() { TopLevel = false, TopMost = true };
            pantActual.FormBorderStyle = FormBorderStyle.None;
            pantActual.ForeColor = System.Drawing.Color.White;
            pantActual.BackColor = Color.FromArgb(5, 8, 13);
            this.panelContainer.Controls.Add(pantActual);
            pantActual.Show();
        }
    }
}
