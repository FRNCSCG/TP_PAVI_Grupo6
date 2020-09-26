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
    public partial class Cursos : Form
    {
        bool ban = false;
        int guardar=0;
        public Cursos()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal pantMenuPrincipal=new MenuPrincipal();
            pantMenuPrincipal.Show();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarComboCategoria();
            Habilitar(false);
        }

        private void CargarGrilla()
        {
            grdCursos.DataSource = AD_Curso.obtenerListado();
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
            this.btnEditar .Enabled = false;
            this.btnBorrar.Enabled = false;
            this.txtIdCurso.Focus();
        }

      
        private void grdCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ban == true || guardar == 1)
            {
                Habilitar(false);
                ban = false;
                guardar = 0;
            }
            btnEditar.Enabled = true ;
            btnBorrar.Enabled = true;
            string id_curso = grdCursos.CurrentRow.Cells[0].Value.ToString();
            Curso c = AD_Curso.RecuperarCurso(int.Parse(id_curso));
            LimpiarCampos();
            cargarCampos(c);

        }

        
        private void btnGrabar_Click(object sender, EventArgs e)      
        {
            Curso c = obtenerCurso();
            //SI EL USUARIO QUIERE CREAR UN CURSO
            if (guardar==1){               

                bool res = AD_Curso.RegistrarCurso(c.Id_curso, c.Nombre, c.Id_categoria, c.Descripcion, c.Fecha_vigencia);
                if (res)
                {
                    MessageBox.Show("Curso registrado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al registrar curso");
                }
               
            }
            //SI EL USUARIO DESEA MODIFICAR UN CURSO
            if(guardar == 2)
            {                

                bool res = AD_Curso.ModificarCurso(c.Id_curso, c.Nombre, c.Id_categoria, c.Descripcion, c.Fecha_vigencia);
                if (res)
                {
                    MessageBox.Show("Curso modificado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al modificar curso");
                }
                

            }
            LimpiarCampos();
            CargarGrilla();
            ban = false;
            this.Habilitar(false);
            guardar = 0;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.ban == false)
            {
                Habilitar(true);
                this.ban = true;
            }
            this.txtIdCurso.Enabled = false;
            this.txtNombre.Focus();
            guardar = 2;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Curso c = obtenerCurso();
            if (MessageBox.Show("Está seguro de eliminar el curso " + txtNombre.Text+"?",
                                "Eliminado",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button2)
                                == DialogResult.Yes)
            {
                bool res = AD_Curso.EliminarCurso(c.Id_curso );
                if (res)
                {
                    MessageBox.Show("Curso eliminado correctamente");
                    LimpiarCampos();
                    CargarGrilla();
                    ban = false;
                    this.Habilitar(false);
                    guardar = 0;
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


        //FUNCIONES
        //NOS PERMITE CREAR UNA CLASE CURSO APARTIR DE LOS CAMPOS DER FORMULARIO
        private Curso obtenerCurso()
        {
            Curso c = new Curso();
            c.Id_curso = int.Parse(txtIdCurso.Text.Trim());
            c.Nombre = txtNombre.Text.Trim();
            c.Fecha_vigencia = dtpFechaVigencia.Value;
            c.Id_categoria = (int)cboCategoria.SelectedValue;
            c.Descripcion = txtDescripcion.Text.Trim();
            return c;
        }

        //TIENE POR PARAMETRO UN CURSO ESPECIFICO Y LA FUNCION LO CARGA EN LOS CAMPOS CORRESPONDIENTES
        private void cargarCampos(Curso c)
        {
            txtDescripcion.Text = c.Descripcion;
            txtIdCurso.Text = c.Id_curso.ToString();
            txtNombre.Text = c.Nombre;
            cboCategoria.SelectedValue = c.Id_categoria;
            dtpFechaVigencia.Value = c.Fecha_vigencia;
        }

        //LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            dtpFechaVigencia.Value = DateTime.Today;
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            txtIdCurso.Text = "";
            cboCategoria.SelectedIndex = -1;
        }

        //CARGAR COMBOS CATEGORIA
        private void CargarComboCategoria()
        {
            cboCategoria.DataSource = AD_Categoria.obtenerCategorias();
            cboCategoria.DisplayMember = "nombre";
            cboCategoria.ValueMember = "id_categoria";
            cboCategoria.SelectedIndex = -1;
        }

        //HABILITAR CAMPOS DEPENDE DE SU PARAMETRO BOOLEANO
        private void Habilitar(bool x)
        {
            txtIdCurso.Enabled = x;
            txtNombre.Enabled = x;
            txtDescripcion.Enabled = x;
            dtpFechaVigencia.Enabled = x;
            cboCategoria.Enabled = x;
            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;           
            btnEditar.Enabled = x;
            btnBorrar.Enabled = x;
        

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ban = false;
            this.Habilitar(false);
            guardar = 0;
        }
        
        
    }
}
