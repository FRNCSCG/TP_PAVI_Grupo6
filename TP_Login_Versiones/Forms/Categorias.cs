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
    public partial class Categorias : Form
    {
        public Categorias()
        {
            InitializeComponent();
        }
        Categoria oCategoria = new Categoria();
        bool nuevo = false;
        Conexion oBD = new Conexion();
        
        private void Categorias_Load(object sender, EventArgs e)
        {
            this.habilitar(false);
            generarGrilla(grdCategorias, oBD.consultarTabla("Categorias"));
        }






        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.nuevo = true;
            this.habilitar(true);
            this.limpiar();
            this.txtIdCategoria.Focus();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.habilitar(true);
            this.txtIdCategoria.Enabled = false;
            this.txtNombreCategoria.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar la categoria " + txtNombreCategoria.Text,
                                  "ELIMINANDO",
                                  MessageBoxButtons.YesNo,
                                  MessageBoxIcon.Error,
                                  MessageBoxDefaultButton.Button2)
                                  == DialogResult.Yes)
            {
                oBD.ELIMINAR_CATEGORIA(int.Parse(txtIdCategoria.Text));
                generarGrilla(grdCategorias, oBD.consultarTabla("categorias"));


            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtIdCategoria.Text.Equals(""))
            {
                MessageBox.Show("No designo ninguna id");
            }
            else
            {
                oCategoria.Id_categoria = int.Parse(txtIdCategoria.Text);
            }

            oCategoria.Nombre = txtNombreCategoria.Text;
            oCategoria.Descripcion = txtDescripcionCat.Text;
            if (this.nuevo)
            {
                if (!existe())
                {
                    if (validarDatosCategoria(oCategoria))
                    {
                        try
                        {
                            oCategoria.Borrado = 0;
                            oBD.CARGAR_CATEGORIA(oCategoria.Id_categoria, oCategoria.Nombre, oCategoria.Descripcion, oCategoria.Borrado);
                            MessageBox.Show("La Categoria se grabó con éxito!");
                        }
                        catch
                        {
                            MessageBox.Show("Error al registrar Categoria");
                        }

                    }
                }
                else
                    MessageBox.Show("Categoria existente");
            }
            else
            {
                if (validarDatosCategoria(oCategoria))
                {
                    try
                    {
                        oCategoria.Id_categoria = int.Parse(txtIdCategoria.Text);
                        oBD.ACTUALIZAR_CATEGORIA(oCategoria.Id_categoria, oCategoria.Nombre, oCategoria.Descripcion);
                        MessageBox.Show("Categoria se grabó con éxito!");
                    }
                    catch
                    {
                        MessageBox.Show("Error al actualizar Categoria");
                    }

                }
            }

            generarGrilla(grdCategorias, oBD.consultarTabla("Categorias"));


            this.habilitar(false);
            this.nuevo = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.habilitar(false);
            this.nuevo = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal pantPrincipal = new Principal();
            pantPrincipal.Show();
        }





        private void generarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_categoria"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["descripcion"]);
            }
        }

        private void habilitar(bool x)
        {
            txtIdCategoria.Enabled = x;
            txtNombreCategoria.Enabled = x;
            txtDescripcionCat.Enabled = x;
            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnSalir.Enabled = !x;
            grdCategorias.Enabled = !x;
        }


        private void grdCategorias_SelectionChanged(object sender, EventArgs e)
        {
            this.actualizarCampos((int)grdCategorias.CurrentRow.Cells[0].Value);
        }

        private void actualizarCampos(int id)
        {
            DataTable tabla = new DataTable();
            tabla = oBD.consultar("SELECT * FROM categorias WHERE id_categoria=" + id);

            txtIdCategoria.Text = tabla.Rows[0]["id_categoria"].ToString();
            txtNombreCategoria.Text = tabla.Rows[0]["nombre"].ToString();
            txtDescripcionCat.Text = tabla.Rows[0]["descripcion"].ToString();

        }

        private void limpiar()
        {
            txtIdCategoria.Clear();
            txtNombreCategoria.Clear();
            txtDescripcionCat.Clear();

        }

        private bool existe()
        {
            DataTable tabla = new DataTable();
            tabla = oBD.consultar("SELECT * FROM categorias WHERE nombre='" + oCategoria.Nombre + "'");
            if (tabla.Rows.Count == 0)
                return false;
            else
                return true;
        }

        private bool validarDatosCategoria(object Categoria)
        {
            if (oCategoria.Nombre == string.Empty)
            {
                MessageBox.Show("El nombre está vacío.");
                return false;
            }

            if (oCategoria.Descripcion == string.Empty)
            {
                MessageBox.Show("No hay descripcion.");
                return false;
            }

            return true;
        }

        private void txtDescripcionCat_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblDescripcionCat_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreCategoria_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIdCategoria_Click(object sender, EventArgs e)
        {

        }

        private void txtIdCategoria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
