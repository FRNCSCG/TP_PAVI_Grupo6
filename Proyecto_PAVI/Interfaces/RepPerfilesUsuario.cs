using Microsoft.Reporting.WinForms;
using Proyecto_PAVI.AccesoBD;
using Proyecto_PAVI.AccesoDatos;
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
    public partial class RepPerfilesUsuario : Form
    {
        public RepPerfilesUsuario()
        {
            InitializeComponent();
        }

        private void RepPerfilesUsuario_Load(object sender, EventArgs e)
        {

            this.reportPU.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            CargarComboPerfil();
            mostrarCompleto();

        }

        private void CargarComboPerfil()
        {
            //CREAR TABLA Y CARGAR CON DATOS
            DataTable datos = AD_Perfil.obtenerPerfiles();

            //CARGAR DATOS CON FILA "TODOS"
            DataRow newRow = datos.NewRow();
            newRow[1] = "Todos";
            newRow[0] = -1;
            datos.Rows.Add(newRow);

            //CARGAR COMBOBOX CON TODAS LAS FILAS
            //CARGAR COMBOS CATEGORIA

            cbPerfiles.DataSource = datos;
            cbPerfiles.DisplayMember = "nombre";
            cbPerfiles.ValueMember = "id_perfil";
            cbPerfiles.SelectedIndex = -1;


        }



        public void verificarCampos(ComboBox combo1)
        {
            if (combo1.SelectedValue is null)
            {
                combo1.Text = "Todos";
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cbPerfiles.Text == "Todos") { mostrarCompleto(); }
            else
            {
                verificarCampos(cbPerfiles);
                DataTable tabla = new DataTable();
                tabla = AD_Perfil.obtenerListadoReporte((int)cbPerfiles.SelectedValue, -1);
                ReportDataSource ds = new ReportDataSource("listadoPerfilesUsuario", tabla);
                this.reportPU.LocalReport.DataSources.Clear();
                this.reportPU.LocalReport.DataSources.Add(ds);
                this.reportPU.RefreshReport();
                lblCantidad.Text = "Cantidad de registros:" + tabla.Rows.Count;
            }

        }



        public void mostrarCompleto()
        {
            verificarCampos(cbPerfiles);
            DataTable tabla = new DataTable();
            tabla = AD_Perfil.obtenerListadoReporteCompleto();
            ReportDataSource ds = new ReportDataSource("listadoPerfilesUsuario", tabla);
            this.reportPU.LocalReport.DataSources.Clear();
            this.reportPU.LocalReport.DataSources.Add(ds);
            this.reportPU.RefreshReport();
            lblCantidad.Text = "Cantidad de registros:" + tabla.Rows.Count;
        
        }




    }
}
