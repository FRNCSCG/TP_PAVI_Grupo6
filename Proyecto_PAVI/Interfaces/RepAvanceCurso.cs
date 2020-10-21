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
    public partial class RepAvanceCurso : Form
    {
        public RepAvanceCurso()
        {
            InitializeComponent();
        }

        private void RepAvanceCurso_Load(object sender, EventArgs e)
        {

            this.repAvances.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            CargarComboCurso();
            CargarComboUsuario();

            verificarCampos(cbCursos2, cbInscriptos2);            

            DataTable tabla = new DataTable();
            tabla = AD_AvanceCurso.obtenerListadoReporte(-1, -1);
            ReportDataSource ds = new ReportDataSource("listadoDeAvances", tabla);

            this.repAvances.LocalReport.DataSources.Clear();
            this.repAvances.LocalReport.DataSources.Add(ds);
            this.repAvances.LocalReport.Refresh();
            this.lblCantidad.Text = "Cantidad de registros:" + tabla.Rows.Count;
        }

        


        //CARGAR COMBOS CURSO
        private void CargarComboCurso()
        {
            //CREAR TABLA Y CARGAR CON DATOS
            DataTable datos = AD_Curso.obtenerCursos();

            //CARGAR DATOS CON FILA "TODOS"
            DataRow newRow = datos.NewRow();
            newRow[1] = "Todos";
            newRow[0] = -1;
            datos.Rows.Add(newRow);

            //CARGAR COMBOBOX CON TODAS LAS FILAS
            //CARGAR COMBOS CATEGORIA

            cbCursos2.DataSource = datos;
            cbCursos2.DisplayMember = "nombre";
            cbCursos2.ValueMember = "id_curso";
            cbCursos2.SelectedIndex = -1;


        }

        //CARGAR COMBOS INSCRIPTOS
        public void CargarComboUsuario()
        {
            //CREAR TABLA Y CARGAR CON DATOS
            DataTable datos = AD_Usuario.obtenerUsuario();



            //CARGAR DATOS CON FILA "TODOS"
            DataRow newRow = datos.NewRow();
            newRow[2] = "Todos";
            newRow[0] = -2;
            datos.Rows.Add(newRow);

            //CARGAR COMBOBOX CON TODAS LAS FILAS
            //CARGAR COMBOS CATEGORIA

            cbInscriptos2.DataSource = datos;
            cbInscriptos2.DisplayMember = "usuario";
            cbInscriptos2.ValueMember = "id_usuario";
            cbInscriptos2.SelectedIndex = -1;

        }


        public void verificarCampos(ComboBox combo1, ComboBox combo2)
        {
            if (combo1.SelectedValue is null)
            {
                combo1.Text = "Todos";
            }
            if (combo2.SelectedValue is null)
            {
                combo2.Text = "Todos";
            }          

        }

        private void btnMostrarTodos2_Click(object sender, EventArgs e)
        {

            verificarCampos(cbCursos2, cbInscriptos2);
            DataTable tabla = new DataTable();

            tabla = AD_AvanceCurso.obtenerListadoReporte(-1, -1);
            ReportDataSource ds = new ReportDataSource("listadoDeAvances", tabla);
            this.repAvances.LocalReport.DataSources.Clear();
            this.repAvances.LocalReport.DataSources.Add(ds);
            this.repAvances.RefreshReport();
            this.lblCantidad.Text = "Cantidad de registros:" + tabla.Rows.Count;
            reset();

        }

        private void btnFiltrar2_Click(object sender, EventArgs e)
        {
            verificarCampos(cbCursos2, cbInscriptos2);

            DataTable tabla = new DataTable();
            tabla = AD_AvanceCurso.obtenerListadoReporte((int)cbCursos2.SelectedValue, (int)cbInscriptos2.SelectedValue);
            ReportDataSource ds = new ReportDataSource("listadoDeAvances", tabla);
            this.repAvances.LocalReport.DataSources.Clear();
            this.repAvances.LocalReport.DataSources.Add(ds);
            this.repAvances.RefreshReport();
            lblCantidad.Text = "Cantidad de registros:" + tabla.Rows.Count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void reset()
        {
            cbCursos2.Text = "Todos";
            cbInscriptos2.Text = "Todos";
        }
    }
}
