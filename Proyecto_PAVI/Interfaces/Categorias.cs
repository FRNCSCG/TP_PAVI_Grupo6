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
    public partial class Categorias : Form
    {
        bool ban = false;
        int guardar = 0;
        public Categorias()
        {
            InitializeComponent();
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
            this.txtIdCategoria .Focus();
        }
        
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Categoria c = obtenerCategoria();
            if (MessageBox.Show("Está seguro de eliminar el curso " + txtNombreCategoria .Text + "?",
                                "Eliminado",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button2)
                                == DialogResult.Yes)
            {
                bool res = AD_Categoria.EliminarCategoria(c.Id_cat );
                if (res)
                {
                    MessageBox.Show("Categoria eliminada correctamente");
                    LimpiarCampos();
                    CargarGrilla();
                    ban = false;
                    this.Habilitar(false);
                    guardar = 0;
                }
                else
                {
                    MessageBox.Show("Error al eliminar Categoria");
                }
            }
                       

        }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.ban == false)
            {
                Habilitar(true);
                this.ban = true;
            }
            this.txtIdCategoria .Enabled = false;
            this.txtNombreCategoria .Focus();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (this.ban == false)
            {
                Habilitar(true);
                this.ban = true;
            }
            this.txtIdCategoria .Enabled = false;
            this.txtNombreCategoria .Focus();
            guardar =2;
        }



        private void btnGrabar_Click_1(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Categoria c = obtenerCategoria();
                //SI EL USUARIO QUIERE CREAR UN CURSO
                if (guardar == 1)
                {

                    bool res = AD_Categoria.RegistrarCategoria(c.Id_cat, c.Nombre, c.Descripcion);
                    if (res)
                    {
                        MessageBox.Show("Categoria registrada correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar Categoria");
                    }

                }
                //SI EL USUARIO DESEA MODIFICAR UN CURSO
                if (guardar == 2)
                {

                    bool res = AD_Categoria.ModificarCategoria(c.Id_cat, c.Nombre, c.Descripcion);
                    if (res)
                    {
                        MessageBox.Show("Categoria modificada correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar categoria");
                    }


                }
                LimpiarCampos();
                CargarGrilla();
                ban = false;
                this.Habilitar(false);
                guardar = 0;
            }



            
        }


        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            ban = false;
            this.Habilitar(false);
            guardar = 0;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCategorias_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (ban == true || guardar == 1)
            {
                Habilitar(false);
                ban = false;
                guardar = 0;
            };
            btnEditar.Enabled = true;
            btnBorrar.Enabled = true;
            string id_categoria = dgvCategorias.CurrentRow.Cells[0].Value.ToString();
            Categoria c = AD_Categoria.RecuperarCategoria(int.Parse(id_categoria));
            LimpiarCampos();
            cargarCampos(c);
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        //FUNCIONES
        //HABILITAR CAMPOS DEPENDE DE SU PARAMETRO BOOLEANO
        private void Habilitar(bool x)
        {
            txtIdCategoria.Enabled = x;
            txtNombreCategoria.Enabled = x;
            txtDescripcionCat.Enabled = x;
            btnGrabar.Enabled = x;
            btnEditar.Enabled = x;
            btnBorrar.Enabled = x;
            btnCancelar.Enabled = x;

        }

        //LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            txtNombreCategoria.Text = "";
            txtIdCategoria.Text = "";
            txtDescripcionCat.Text = "";
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            Habilitar(false);
        }

        private void CargarGrilla()
        {
            dgvCategorias.DataSource = AD_Categoria.obtenerListadoCategorias();
        }

        private Categoria obtenerCategoria()
        {
            Categoria cat = new Categoria();
            cat.Id_cat = int.Parse(txtIdCategoria.Text.Trim());
            cat.Nombre = txtNombreCategoria.Text.Trim();
            cat.Descripcion = txtDescripcionCat.Text.Trim();
            return cat;
        }

        private void cargarCampos(Categoria c)
        {
            txtDescripcionCat.Text = c.Descripcion;
            txtIdCategoria.Text = c.Id_cat.ToString();
            txtNombreCategoria.Text = c.Nombre;
        }




        public bool validarCampos()
        {
            if (txtIdCategoria.Text == "")
            {
                MessageBox.Show("El id está vacío");
                return false;
            }
            if (txtNombreCategoria.Text == "")
            {
                MessageBox.Show("El nombre está vacío");
                return false;
            }
            if (txtDescripcionCat.Text == "")
            {
                MessageBox.Show("La descripcion está vacia...");
                return false;
            }

            return true;
        }


    }
}
