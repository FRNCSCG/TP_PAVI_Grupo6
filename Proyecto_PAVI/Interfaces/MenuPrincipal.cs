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

            Cursos pantCurso = new Cursos();
            pantCurso.ShowDialog();

        }

        private void objetivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Objetivos pantObjetivo = new Objetivos();
            pantObjetivo.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Categorias pantCategoria = new Categorias();
            pantCategoria.ShowDialog();
        }



        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {

            HistorialInscripciones pantHistorial = new HistorialInscripciones();
            pantHistorial.ShowDialog();
        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Inscripciones pantIncripciiones = new Inscripciones();
            pantIncripciiones.ShowDialog();
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepInscripciones pantRepIns = new RepInscripciones();
            pantRepIns.ShowDialog();
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

      

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepAvanceCurso pantAvanceCurso = new RepAvanceCurso();
            pantAvanceCurso.ShowDialog();
        }

        private void usuariosPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepUsuariosXCurso pantUsuariosCursos = new RepUsuariosXCurso();
            pantUsuariosCursos.ShowDialog();
        }

        private void perfilesDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepPerfilesUsuario pantPerfilesUsuario = new RepPerfilesUsuario();
            pantPerfilesUsuario.ShowDialog();
        }

        private void cantidadUsuariosPorCursoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RepEstUsuariosCursos pantCantUsuarios = new RepEstUsuariosCursos();
            pantCantUsuarios.ShowDialog();
        }

        private void puntuacionUsuariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RepEstPuntuacionUsuarios pantPuntUsuarios = new RepEstPuntuacionUsuarios();
            pantPuntUsuarios.ShowDialog();
        }

        private void cantidadUsuariosPorPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepEstUsuariosPerfiles perfils = new RepEstUsuariosPerfiles();
            perfils.ShowDialog();
        }

        private void cantidadActividadesDeInscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepEstActividadesInscripciones activs = new RepEstActividadesInscripciones();
            activs.ShowDialog();
        }
    }
}
