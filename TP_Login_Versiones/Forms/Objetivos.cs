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
    public partial class Objetivos : Form
    {
        
        Objetivo oObjetivo = new Objetivo();
        bool nuevo = false;

        Conexion oBD = new Conexion();
        public Objetivos()
        {
            InitializeComponent();
        }

        private void Objetivos_Load(object sender, EventArgs e)
        {
            this.habilitar(false);
            generarGrilla(grdObjetivos, oBD.consultarTabla("Cursos"));
        }

        private void generarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_objetivo"],
                                tabla.Rows[i]["nombre_largo"],
                                tabla.Rows[i]["nombre_corto"]);
            }
        }

        private void grdCursos_SelectionChanged(object sender, EventArgs e)
        {
            this.actualizarCampos((int)grdObjetivos.CurrentRow.Cells[0].Value);
        }

        private void actualizarCampos(int id)
        {
            DataTable tabla = new DataTable();
            tabla = oBD.consultar("SELECT * FROM objetivos WHERE id_curso=" + id);

            txtIdObjetivo .Text = tabla.Rows[0]["id_objetivo"].ToString();
            txtNombreLargo.Text = tabla.Rows[0]["nombre_largo"].ToString();
            txtNombreAbrev .Text = tabla.Rows[0]["nombre_corto"].ToString();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de eliminar el objetivo " + txtNombreLargo .Text,
                                "ELIMINANDO",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button2)
                                == DialogResult.Yes)
            {
                oBD.ELIMINAR("objetivos", int.Parse(txtIdObjetivo .Text));
                generarGrilla(grdObjetivos , oBD.consultarTabla("Cursos"));


            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.habilitar(true);
            this.txtIdObjetivo .Enabled = false;
            this.txtNombreLargo .Focus();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.nuevo = true;
            this.habilitar(true);
            this.limpiar();
            this.txtIdObjetivo .Focus();
        }

        private void limpiar()
        {
            txtIdObjetivo .Clear();
            txtNombreLargo .Clear();
            txtNombreAbrev .Clear();

        }

        private void habilitar(bool x)
        {
            txtIdObjetivo .Enabled = x;
            txtNombreAbrev .Enabled = x;
            txtNombreLargo .Enabled = x;
            btnGrabar.Enabled = x;
            btnCancelar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnSalir.Enabled = !x;
            grdObjetivos .Enabled = !x;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtIdObjetivo.Text.Equals("")) {
                MessageBox.Show("No designo ninguna id");
            }
            else
            {
                oObjetivo.Id_objetivo = int.Parse(txtIdObjetivo.Text);
            }
                
                oObjetivo.Nombre_largo  = txtNombreLargo .Text;
                oObjetivo.Nombre_corto  = txtNombreAbrev .Text;
                if (this.nuevo)
                {
                    if (!existe())
                    {
                        if (validarDatosObjetivo(oObjetivo ))
                        {
                            try
                            {
                                oObjetivo .Borrado = 0;
                                oBD.CARGAR_OBJETIVO (oObjetivo.Id_objetivo ,oObjetivo.Nombre_largo,oObjetivo.Nombre_corto , oObjetivo .Borrado);
                                MessageBox.Show("El objetivo se grabó con éxito!");
                            }
                            catch
                            {
                                MessageBox.Show("Error al registrar objetivo");
                            }

                        }
                    }
                    else
                        MessageBox.Show("Objetivo existente");
                }
                else
                {
                    if (validarDatosObjetivo(oObjetivo))
                    {
                        try
                        {
                            oObjetivo.Id_objetivo  = int.Parse(txtIdObjetivo .Text);
                            oBD.ACTUALIZAR_OBJETIVO (oObjetivo.Id_objetivo, oObjetivo.Nombre_largo, oObjetivo.Nombre_corto);
                            MessageBox.Show("El objetivo se grabó con éxito!");
                        }
                        catch
                        {
                            MessageBox.Show("Error al actualizar objetivo");
                        }

                    }
                }

                generarGrilla(grdObjetivos  , oBD.consultarTabla("objetivos"));


                this.habilitar(false);
                this.nuevo = false;
            
        }

        private bool existe()
        {
            DataTable tabla = new DataTable();
            tabla = oBD.consultar("SELECT * FROM objetivos WHERE nombre_largo='" + oObjetivo.Nombre_largo   + "'");
            if (tabla.Rows.Count == 0)
                return false;
            else
                return true;
        }

        private bool validarDatosObjetivo(object Curso)
        {
            if (oObjetivo .Nombre_largo  == string.Empty)
            {
                MessageBox.Show("El nombre está vacío.");
                return false;
            }

            if (oObjetivo.Nombre_corto  == string.Empty)
            {
                MessageBox.Show("No hay descrpcion.");
                return false;
            }
            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Principal pantPrincipal = new Principal();
            pantPrincipal.Show();
        }
    }
}
