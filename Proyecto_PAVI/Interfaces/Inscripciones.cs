using Proyecto_PAVI.AccesoDatos;
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
    public partial class Inscripciones : Form
    {
        bool ban = false;
        int guardar = 0;
        public Inscripciones()
        {
            InitializeComponent();
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarComboCategoria();
            Habilitar(false);
        }

        private void Habilitar(bool v)
        {
            tbLegajo.Enabled   = v;
            cbCurso.Enabled = v;
            dtpFechaInicio.Enabled  = v;
            txtObservacion.Enabled = v;
            cbPuntuacion.Enabled = v;

        }

        private void CargarComboCategoria()
        {
            cbCurso.DataSource = AD_Curso.obtenerCursos();
            cbCurso .DisplayMember = "nombre";
            cbCurso.ValueMember = "id_curso";
            cbCurso.SelectedIndex = -1;
        }

        private void CargarGrilla()
        {
            dgvInscripcion .DataSource = AD_Inscripcion.obtenerListado();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (this.ban == false)
            {
                Habilitar(true);
                this.ban = true;
            }
            guardar = 1;
            LimpiarCampos();
            this.btnEditar.Enabled = false;
            this.btnBorrar.Enabled = false;
            this.tbLegajo .Focus();
        }

        private void LimpiarCampos()
        {
            tbLegajo.Text = "";
            cbCurso.Text = "";
            dtpFechaInicio.Value = DateTime.Today;
            txtObservacion.Text = "";
            cbPuntuacion.Text = "";
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            EstudiantesCurso est = obtenerInscripcion();
            //SI EL USUARIO QUIERE CREAR UN CURSO
            if (guardar == 1)
            {

                bool res = AD_Inscripcion .RegistrarInscripcion(est.Id_usuario,est.Id_curso,est.Fecha_inicio,est.Fecha_fin,est.Puntuacion ,est.Observaciones );
                if (res)
                {
                    AD_AvanceCurso.RegistrarAvance(est.Id_usuario ,est.Id_curso ,est.Fecha_inicio,est.Fecha_fin);
                    MessageBox.Show("Curso registrado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al registrar curso");
                }

            }
            ////SI EL USUARIO DESEA MODIFICAR UN CURSO
            //if (guardar == 2)
            //{

            //    bool res = AD_Curso.ModificarCurso(c.Id_curso, c.Nombre, c.Id_categoria, c.Descripcion, c.Fecha_vigencia);
            //    if (res)
            //    {
            //        MessageBox.Show("Curso modificado correctamente");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error al modificar curso");
            //    }


            //}
            LimpiarCampos();
            CargarGrilla();
            ban = false;
            this.Habilitar(false);
            guardar = 0;
        }

        private EstudiantesCurso obtenerInscripcion()
        {
            EstudiantesCurso c = new EstudiantesCurso();
            Curso curso = AD_Curso.RecuperarCurso((int)(cbCurso.SelectedValue));
            if (cbPuntuacion.SelectedItem is null)
            {
                c.Puntuacion = 0;

            }
            else
            {
                c.Id_curso = (int)(cbCurso.SelectedValue);

            }
            
            c.Id_usuario  = int.Parse(tbLegajo.Text.Trim());
            c.Fecha_inicio  = dtpFechaInicio .Value;           
            c.Observaciones  = txtObservacion .Text.Trim();
            c.Fecha_fin = curso.Fecha_vigencia;
            return c;
        }

        private void dgvInscripcion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ban == true || guardar == 1)
            {
                Habilitar(false);
                ban = false;
                guardar = 0;
            }
            btnEditar.Enabled = true;
            btnBorrar.Enabled = true;
            
            string id_curso = dgvInscripcion.CurrentRow.Cells[1].Value.ToString();            
            string id_usuario = dgvInscripcion.CurrentRow.Cells[0].Value.ToString();
            EstudiantesCurso est= AD_Inscripcion .RecuperarInscripcion(int.Parse(id_curso),int.Parse(id_usuario));
            LimpiarCampos();
            cargarCampos(est);
        }

        private void cargarCampos(EstudiantesCurso c)
        {
            txtObservacion .Text = c.Observaciones ;
            tbLegajo .Text = c.Id_usuario .ToString();
            cbCurso .SelectedValue = c.Id_curso .ToString();
            cbPuntuacion .SelectedItem = c.Puntuacion.ToString();
            dtpFechaInicio.Value = c.Fecha_inicio;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            EstudiantesCurso  est = obtenerInscripcion ();
            if (MessageBox.Show("Está seguro que desea eliminar la inscripcion del legajo " + tbLegajo .Text + " en el curso"+cbCurso.ToString ()+"?",
                                "Eliminado",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button2)
                                == DialogResult.Yes)
            {
                bool res = AD_Inscripcion.EliminarCurso(est.Id_curso, est.Id_usuario );
                if (res)
                {
                    MessageBox.Show("Curso eliminado correctamente");
                    
                }
                else
                {
                    MessageBox.Show("Error al eliminar curso");
                }
            }


            LimpiarCampos();
            CargarGrilla();
            ban = false;
            this.Habilitar(false);
            guardar = 0;
        }
    }
}
