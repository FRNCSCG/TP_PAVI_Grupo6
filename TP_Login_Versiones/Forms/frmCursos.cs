using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Login_Versiones.Class;

namespace TP_Login_Versiones.Forms
{
    public partial class frmCursos : Form
    {
        public frmCursos()
        {
            InitializeComponent();
        }
        
        Conexion oBD = new Conexion();
        Curso oCurso = new Curso();
        
        bool nuevo = false;

        private void frmCursos_Load(object sender, EventArgs e)
        {
            this.habilitar(false);
            txtIdCurso.Enabled = false;
            cargarCombo("categorias");
            generarGrilla(grdCursos, oBD.consultarTabla("Cursos"));
        }



        //botones
        
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.nuevo = true;
            this.habilitar(true);
            this.limpiar();
            this.txtIdCurso.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            oCurso.Id_curso = int.Parse(txtIdCurso.Text);
            oCurso.Nombre = txtNombre.Text;
            oCurso.Descripcion = txtDescripcion.Text;
            oCurso.Fecha_vigencia = dtpFechaVigencia.Value;
            oCurso.Id_categoria = cboCategoria.SelectedIndex;
            if (this.nuevo)
            {
                if (!existe())
                {
                    if (validarDatosCurso(oCurso))
                    {
                        oCurso.Borrado = 0;
                        oBD.CARGAR_CURSO(oCurso.Id_curso,oCurso.Nombre, oCurso.Descripcion, oCurso.Fecha_vigencia, oCurso.Id_categoria,oCurso.Borrado);
                        MessageBox.Show("El curso se grabó con éxito!");
                    }
                }
                else
                    MessageBox.Show("Curso existente");
            }
            else
            {
                if (validarDatosCurso(oCurso))
                {
                    oCurso.Id_curso = int.Parse(txtIdCurso.Text);
                    oBD.ACTUALIZAR_CURSO(oCurso.Id_curso, oCurso.Nombre, oCurso.Descripcion, oCurso.Fecha_vigencia, oCurso.Id_categoria);
                    MessageBox.Show("El curso se grabó con éxito!");
                }
            }

            generarGrilla(grdCursos, oBD.consultarTabla("Cursos"));

    
            this.habilitar(false);
            this.nuevo = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.habilitar(false);
            this.nuevo = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.habilitar(true);
            this.txtIdCurso.Enabled = false;
            this.txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar el curso " + txtNombre.Text,
                                "ELIMINANDO",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button2)
                                == DialogResult.Yes)
            {
                oBD.ELIMINAR_CURSO(int.Parse(txtIdCurso.Text));
                generarGrilla(grdCursos, oBD.consultarTabla("Cursos"));


            }
        }




        //funciones

        private void generarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_curso"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["id_categoria"],
                                tabla.Rows[i]["fecha_vigencia"]);
            }
        }


        private void habilitar(bool x)
        {
            txtIdCurso.Enabled = x;
            txtNombre.Enabled = x;
            txtDescripcion.Enabled = x;
            dtpFechaVigencia.Enabled = x;
            cboCategoria.Enabled = x;
            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnSalir.Enabled = !x;
            grdCursos.Enabled = !x;
        }


        private void limpiar()
        {
            txtIdCurso.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            cboCategoria.SelectedIndex = -1;
            dtpFechaVigencia.Value = DateTime.Today;

        }


        private void cargarCombo(string nombreTabla)
        {
            DataTable tabla = new DataTable();
            tabla = oBD.consultarTabla(nombreTabla);
            cboCategoria.DataSource = tabla;
            cboCategoria.DisplayMember = tabla.Columns[1].ColumnName;
            cboCategoria.ValueMember = tabla.Columns[0].ColumnName;
            cboCategoria.SelectedIndex = -1;
        }



        private void grdCursos_SelectionChanged(object sender, EventArgs e)   
        {
            this.actualizarCampos((int)grdCursos.CurrentRow.Cells[0].Value);
        }

        private void actualizarCampos(int id)
        {
            DataTable tabla = new DataTable();
            tabla = oBD.consultar("SELECT * FROM cursos WHERE id_curso=" + id);
            
            txtIdCurso.Text = tabla.Rows[0]["id_curso"].ToString();
            txtNombre.Text = tabla.Rows[0]["nombre"].ToString();
            txtDescripcion.Text = tabla.Rows[0]["descripcion"].ToString();
            dtpFechaVigencia.Value = (DateTime)tabla.Rows[0]["fecha_vigencia"];
            cboCategoria.SelectedValue = tabla.Rows[0]["id_categoria"];

        }


        private bool existe()
        {
            DataTable tabla = new DataTable();
            tabla = oBD.consultar("SELECT * FROM cursos WHERE nombre='" + oCurso.Nombre + "'");
            if (tabla.Rows.Count == 0)
                return false;
            else
                return true;
        }


        private bool validarDatosCurso(object Curso)
        {


            if (oCurso.Nombre == string.Empty)
            {
                MessageBox.Show("El nombre está vacío.");
                return false;
            }

            if (oCurso.Descripcion == string.Empty)
            {
                MessageBox.Show("No hay descrpcion.");
                return false;
            }

            if (oCurso.Id_categoria == -1)
            {
                MessageBox.Show("Seleccione categoria");
                return false;
            }

            return true;

        }



    }


}


