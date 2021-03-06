﻿using Proyecto_PAVI.AccesoBD;
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
            Llenar_Combo(cbCurso ,AD_Curso.obtenerCursos() ,"nombre","id_curso");
            Llenar_Combo(cbUsuario , AD_Usuario.obtenerUsuario(), "usuario", "id_usuario");
            Habilitar(false);
            btnCancelar.Enabled = false;
            btnGrabar.Enabled = false;
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
            this.cbUsuario  .Focus();
        }

       

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            if (validarCampos())
            {
                EstudiantesCurso est = obtenerInscripcion();
                //SI EL USUARIO QUIERE CREAR UN CURSO
                if (guardar == 1)
                {

                    bool res = AD_Inscripcion.RegistrarTransaccion(est.Id_usuario, est.Id_curso, est.Fecha_inicio, est.Fecha_fin, est.Puntuacion, est.Observaciones);
                    if (res)
                    {

                        MessageBox.Show("Inscripcion registrada correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar inscripcion");
                    }

                }
                //SI EL USUARIO DESEA MODIFICAR UN CURSO
                if (guardar == 2)
                {

                    bool res = AD_Inscripcion.ModificarInscripcion(est.Id_curso, est.Id_usuario, est.Puntuacion, est.Observaciones);
                    if (res)
                    {
                        MessageBox.Show("Inscripcion modificada correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar inscripcion");
                    }


                }
                LimpiarCampos();
                CargarGrilla();
                ban = false;
                this.Habilitar(false);
                guardar = 0;

            }
            
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
                c.Puntuacion = int.Parse ((string )(cbPuntuacion.SelectedItem ));

            }
            
            c.Id_usuario  = (int)cbUsuario.SelectedValue ;
            c.Id_curso  = (int)cbCurso.SelectedValue  ;
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //SI NO SELECCIONO UNA INSCRIPCION
            if(cbUsuario.SelectedIndex.Equals(-1) || cbCurso.SelectedIndex.Equals(-1)){
                MessageBox.Show("Por favor seleccion una inscripcion a eliminar");
            }
            //SI SELECCIONO UNA INSCRIPCION
            else
            {
                //OBTENER INSCRIPCION SELECCIONADA
                EstudiantesCurso est = obtenerInscripcion();
                //OBTIENE CURSO SELECIONADO PARA MOSTRAR NOMBRE
                Curso curso = AD_Curso.RecuperarCurso(est.Id_curso);
                if (MessageBox.Show("Está seguro que desea eliminar la inscripcion del legajo " + cbUsuario .Text + " en el curso " + curso.Nombre + "?",
                                    "Eliminado",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button2)
                                    == DialogResult.Yes)
                {
                    //ELIMINA EL AVANCE YA QUE TIENE UNA PK 
                    //DEPENDIENTE DE INSCRIPCION
                    bool res = AD_AvanceCurso.EliminarAvance(est.Id_curso, est.Id_usuario, est.Fecha_inicio); ;
                    if (res)
                    {   //Y POR ULTIMO ELIMINAR EL CURSO
                        AD_Inscripcion.EliminarInscripcion(est.Id_curso, est.Id_usuario);                        

                    }
                    else
                    //SI NO SE PUEDO ELIMINAR EL AVANCE
                    //NO ELIMINA LA INSCRIPCION
                    {
                        MessageBox.Show("Error al eliminar Inscripcion");
                    }
                }


                LimpiarCampos();
                CargarGrilla();
                ban = false;
                this.Habilitar(false);
                guardar = 0;
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.ban == false)
            {
                Habilitar(true);
                this.ban = true;
            }
            this.cbUsuario.Enabled = false;
            this.cbCurso .Enabled = false;
            this.dtpFechaInicio .Enabled = false;
            this.cbPuntuacion .Focus();
            guardar = 2;
        }

        //FUNCIONES
        //NOS AYUDAR A CARGAR LOS CAMPOS
        //ATRAVES DEL PARAMETRO OBJETO ESTUDIANTECURSO
        private void cargarCampos(EstudiantesCurso c)
        {
            txtObservacion.Text = c.Observaciones;
            cbUsuario.SelectedValue = c.Id_usuario.ToString();
            cbCurso.SelectedValue = c.Id_curso;
            cbPuntuacion.SelectedItem = c.Puntuacion.ToString();
            dtpFechaInicio.Value = c.Fecha_inicio;
        }

        //NOS AYUDA A LIMPIAR TODOS LOS CAMPOS
        private void LimpiarCampos()
        {
            cbUsuario.Text = "";
            cbCurso.Text = "";
            dtpFechaInicio.Value = DateTime.Today;
            txtObservacion.Text = "";
            cbPuntuacion.SelectedItem  = null;
        }

        //NOS AYUDA A CARGAR EL DATAGRIDVIEW
        private void CargarGrilla()
        {
            dgvInscripcion.DataSource = AD_Inscripcion.obtenerListado();
        }


        //NOS PERMITE HABILITAR/DESHABILITAR LOS CAMPOS
        private void Habilitar(bool v)
        {
            cbUsuario.Enabled = v;
            cbCurso.Enabled = v;
            dtpFechaInicio.Enabled = v;
            txtObservacion.Enabled = v;
            cbPuntuacion.Enabled = v;
            btnGrabar.Enabled = v;
            btnCancelar.Enabled = v;


        }

        //NOS PERMITE CARGAR COMBOS
        private void Llenar_Combo(ComboBox combo, DataTable  datos, string display, string value)
        {
            combo.DataSource = datos;
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.SelectedValue = -1;
        }
       

        //VERIFICA QUE NO HAYA CAMPOS SIN LLENAR
        public bool validarCampos()
        {
            if (cbUsuario.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("El legajo está vacío");
                return false;
            }
            
            if (cbCurso.SelectedIndex==-1)
            {
                MessageBox.Show("elegir curso");
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ban = false;
            this.Habilitar(false);
            LimpiarCampos();
            guardar = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
