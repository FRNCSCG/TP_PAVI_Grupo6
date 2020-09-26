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
        }

        private void cuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cursos pantCurso = new Cursos();
            pantCurso.Show();

        }

        private void objetivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Objetivos pantObjetivo = new Objetivos();
            pantObjetivo.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Categorias pantCategoria = new Categorias();
            pantCategoria.Show();
        }
    }
}
