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
    public partial class Objetivos : Form
    {

        bool ban = false;
        int guardar = 0;

        public Objetivos()
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
            this.txtIdObjetivo .Focus();
        }

        private void Objetivo_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            Habilitar(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ban = false;
            this.Habilitar(false);
            guardar = 0;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Objetivo o = obtenerObjetivo();
            //SI EL USUARIO QUIERE CREAR UN CURSO
            if (guardar == 1)
            {

                bool res = AD_Objetivo.RegistrarObjetivo(o.Id_objetivo ,o.Nombre_corto , o.Nombre_largo );
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
            if (guardar == 2)
            {

                bool res = AD_Objetivo.ModificarObjetivo(o.Id_objetivo, o.Nombre_corto, o.Nombre_largo);
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
            
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal pantMenuPrincipal = new MenuPrincipal();
            pantMenuPrincipal.Show();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Objetivo c = obtenerObjetivo();
            if (MessageBox.Show("Está seguro de eliminar el curso " + txtNombreLargo .Text + "?",
                                "Eliminado",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button2)
                                == DialogResult.Yes)
            {
                bool res = AD_Objetivo.EliminarObjetivo(c.Id_objetivo );
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
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.ban == false)
            {
                Habilitar(true);
                this.ban = true;
            }
            this.txtIdObjetivo .Enabled = false;
            this.txtNombreAbrev .Focus();
            guardar = 2;
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ban == true || guardar == 1)
            {
                Habilitar(false);
                ban = false;
                guardar = 0;
            };
            btnEditar.Enabled = true;
            btnBorrar.Enabled = true;
            string id_objetivo= dgvObjetivos.CurrentRow.Cells[0].Value.ToString();
            Objetivo  o = AD_Objetivo.RecuperarObjetivo (int.Parse(id_objetivo));
            LimpiarCampos();
            cargarCampos(o);
        }


        //FUNCIONES
        private void CargarGrilla()
        {
            dgvObjetivos.DataSource = AD_Objetivo.obtenerListadoObjetivos();
        }
        //HABILITAR CAMPOS DEPENDE DE SU PARAMETRO BOOLEANO
        private void Habilitar(bool x)
        {
            txtIdObjetivo.Enabled = x;
            txtNombreAbrev.Enabled = x;
            txtNombreLargo.Enabled = x;
            btnGrabar.Enabled = x;
            btnEditar.Enabled = x;
            btnBorrar.Enabled = x;
            btnCancelar.Enabled = x;

        }

        //LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            txtIdObjetivo.Text = "";
            txtNombreAbrev.Text = "";
            txtNombreLargo.Text = "";
        }

        //NOS PERMITE CREAR UNA CLASE CURSO APARTIR DE LOS CAMPOS DER FORMULARIO
        private Objetivo obtenerObjetivo()
        {
            Objetivo c = new Objetivo();
            c.Id_objetivo = int.Parse(txtIdObjetivo.Text.Trim());
            c.Nombre_corto = txtNombreAbrev.Text.Trim();
            c.Nombre_largo = txtNombreLargo.Text.Trim();
            return c;
        }

        private void cargarCampos(Objetivo o)
        {
            txtNombreLargo.Text = o.Nombre_largo;
            txtIdObjetivo .Text = o.Id_objetivo .ToString();
            txtNombreAbrev .Text = o.Nombre_corto ;
        }
    }
}
