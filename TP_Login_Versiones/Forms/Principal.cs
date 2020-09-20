using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Login_Versiones.Forms
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCursos PantCursos=new frmCursos();
            PantCursos.Show();
            this.Hide();
        }

        private void objertivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Objetivos pantObjetivos = new Objetivos();
            pantObjetivos.Show();
            this.Hide();
        }
    }
}
