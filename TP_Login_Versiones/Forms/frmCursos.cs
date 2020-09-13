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
    public partial class frmCursos : Form
    {
        public frmCursos()
        {
            InitializeComponent();
        }
        //Datos oBD = new Datos();
        //Usuario oCurso = new Curso;
        
        bool nuevo = false;

        private void frmCursos_Load(object sender, EventArgs e)
        {
            this.habilitar(false);
            //bool nuevo = false;
            txtIdCurso.Enabled = false;

            DataTable tabla = new DataTable();
            //tabla = oBD.consultarTabla("categorias");
            cboCategoria.DataSource = tabla;
            //cboCategoria.DisplayMember = tabla.Columns[1].ColumnName;
            //cboCategoria.ValueMember = tabla.Columns[0].ColumnName;
            cboCategoria.SelectedIndex = -1;

            //generarGrilla(grdCursos, oUsuario.recuperarCursos());
           



        }

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
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.nuevo = true;
            this.habilitar(true);
            this.limpiar();
            this.txtNombre.Focus();
            btnEditar.Enabled = false;
            btnBorrar.Enabled = false;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
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

                //metodoBorrar


            }
        }

        private void grdCursos_SelectionChanged(object sender, EventArgs e)
        {
            //this.actualizarCampos((int)grdCursos.CurrentRow.Cells[0].Value);

        }

        private void actualizarCampos(int id)
        {
            DataTable tabla = new DataTable();
            //tabla = oUsuario.recuperarCursoPorId(id);
            txtIdCurso.Text = tabla.Rows[0]["id_curso"].ToString();
            txtNombre.Text = tabla.Rows[0]["nombre"].ToString();
            txtDescripcion.Text = tabla.Rows[0]["descripcion"].ToString();
            dtpFechaVigencia.Value = (DateTime)tabla.Rows[0]["fecha_vigencia"];
            cboCategoria.SelectedValue = tabla.Rows[0]["id_categoria"];

        }









}


}


