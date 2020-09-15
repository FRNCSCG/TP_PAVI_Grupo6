using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        Conexion conexion = new Conexion();

        public frmCursos()
        {
            InitializeComponent();
        }
        
        private void frmCursos_Load(object sender, EventArgs e)
        {
            CARGAR_CATEGORIA();
            ACTUALIZARGRILLA();
        }

        

       private void limpiar()
        {
            txtIdCurso.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            cboCategoria.SelectedIndex = -1;
            dtpFechaVigencia.Value = DateTime.Today;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CARGAR_CATEGORIA()
        {
             SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["CadenaDB"]);
             SqlCommand comando = new SqlCommand();
            try
            {
                comando.Connection = conexion;
                comando.Parameters.Clear();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT id_categoria FROM CATEGORIAS";

                conexion.Open();

                SqlDataReader registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    cboCategoria.Items.Add(registro["id_categoria "].ToString());
                }

                conexion.Close();

            }
            catch
            {
                MessageBox.Show("Error al cargar las categorias disponibles");
            }
             

        }
        public void ACTUALIZARGRILLA()
        {
            SqlConnection conexion = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["CadenaDB"]);
            SqlCommand comando = new SqlCommand();
            try
            {
                comando.Connection = conexion;
                comando.Parameters.Clear();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT id_curso , nombre , descripcion , id_categoria  ,fecha_vigencia FROM CURSOS ";

                conexion.Open();

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(tabla);

                grdCursos.DataSource = tabla;

                conexion.Close();

            }
            catch
            {
                MessageBox.Show("Error al cargar los cursos registrados");
            }


        }

       

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Curso nuevoCurso = new Curso(int.Parse(txtIdCurso.Text.Trim()),txtNombre.Text.Trim(),txtDescripcion.Text.Trim(),dtpFechaVigencia.Value ,int.Parse(cboCategoria.Text)  , 0);
            conexion.CARGAR_CURSO(nuevoCurso.Id_curso, nuevoCurso.Nombre, nuevoCurso.Descripcion, nuevoCurso.Fecha_vigencia,nuevoCurso.Id_categoria,nuevoCurso.Borrado );
            ACTUALIZARGRILLA();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIdCurso.Text.Equals(""))
            {
                MessageBox.Show("Por favor,seleccion un curso para modificar");
            }
            else
            {   Curso nuevoCurso = new Curso(int.Parse(txtIdCurso.Text.Trim()), txtNombre.Text.Trim(), txtDescripcion.Text.Trim(), dtpFechaVigencia.Value, int.Parse(cboCategoria.Text),0);
                conexion.ACTUALIZAR_CURSO (nuevoCurso.Id_curso, nuevoCurso.Nombre, nuevoCurso.Descripcion, nuevoCurso.Fecha_vigencia, nuevoCurso.Id_categoria);
                ACTUALIZARGRILLA();

            }
        }

        private void grdCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCurso.Text = grdCursos.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = grdCursos.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = grdCursos.CurrentRow.Cells[2].Value.ToString();
            dtpFechaVigencia.Value = DateTime.Parse(grdCursos.CurrentRow.Cells[4].Value.ToString());
            cboCategoria.Text = grdCursos.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Curso nuevoCurso = new Curso(int.Parse(txtIdCurso.Text.Trim()), txtNombre.Text.Trim(), txtDescripcion.Text.Trim(), dtpFechaVigencia.Value, int.Parse(cboCategoria.Text), 0);
            conexion.ELIMINAR_CURSO(nuevoCurso.Id_curso);
            ACTUALIZARGRILLA();
        }
    }
}

