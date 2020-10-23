﻿using Proyecto_PAVI.Entidades;
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



        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistorialInscripciones pantHistorial = new HistorialInscripciones();
            pantHistorial.Show();
        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inscripciones pantIncripciiones = new Inscripciones();
            pantIncripciiones.Show();
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
                
                lblBienvenido.Text="Bienvenido " + Login.usuarioActual + "!";

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

        private void cantidadUsuariosPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepEstUsuariosCursos pantCantUsuarios = new RepEstUsuariosCursos();
            pantCantUsuarios.ShowDialog();
        }

        private void puntuacionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RepEstPuntuacionUsuarios pantPuntUsuarios = new RepEstPuntuacionUsuarios();
            pantPuntUsuarios.ShowDialog();
        }
    }
}
