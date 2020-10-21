using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Proyecto_PAVI.AccesoBD;
using Proyecto_PAVI.AccesoDatos;

namespace Proyecto_PAVI.Interfaces
{
    public partial class RepInscripciones : Form
    {

        
        public RepInscripciones()
        {
            InitializeComponent();
        }

        private void RepInscripciones_Load(object sender, EventArgs e)
        {
            
            this.repIns.RefreshReport();

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            verificarCampos(cbCursos, cbInscriptos, cbResponsables);
            
            DataTable tabla = new DataTable();
            tabla = AD_HistorialInscripcion.obtenerListadoReporte(fechaInicio.Value,fechaFin.Value, (int)cbCursos.SelectedValue, (int)cbInscriptos.SelectedValue, (int)cbResponsables.SelectedValue);
            ReportDataSource ds = new ReportDataSource("listadoInscripciones", tabla);
            this.repIns.LocalReport.DataSources.Clear();
            this.repIns.LocalReport.DataSources.Add(ds);
            this.repIns.RefreshReport();
            lblCantidad.Text= "Cantidad de registros:" + tabla.Rows.Count;
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {

            verificarCampos(cbCursos, cbInscriptos, cbResponsables);
            DataTable tabla = new DataTable();
            
            tabla = AD_HistorialInscripcion.obtenerListadoReporte(DateTime.Parse("01/01/1900"), DateTime.Parse("1/01/2100"), -1, -1, -1);
            ReportDataSource ds = new ReportDataSource("listadoInscripciones", tabla);
            this.repIns.LocalReport.DataSources.Clear();
            this.repIns.LocalReport.DataSources.Add(ds);
            this.repIns.RefreshReport();
            lblCantidad.Text = "Cantidad de registros:" + tabla.Rows.Count;

        }

        


        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
            CargarComboCurso();
            CargarComboInscripto();
            CargarComboResponable();
            verificarCampos(cbCursos, cbInscriptos, cbResponsables);
            lblCantidadRegistros.Text = "";
            DataTable tabla = new DataTable();
            tabla = AD_HistorialInscripcion.obtenerListadoReporte(DateTime.Parse("01/01/1900"), DateTime.Parse("1/01/2100"), -1, -1, -1);
            ReportDataSource ds = new ReportDataSource("listadoInscripciones", tabla);
            this.repIns.LocalReport.DataSources.Clear();
            this.repIns.LocalReport.DataSources.Add(ds);
            this.repIns.RefreshReport();
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

            cbCursos.DataSource = datos;
            cbCursos.DisplayMember = "nombre";
            cbCursos.ValueMember = "id_curso";
            cbCursos.SelectedIndex = -1;


        }

        //CARGAR COMBOS INSCRIPTOS
        public void CargarComboInscripto()
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

            cbInscriptos.DataSource = datos;
            cbInscriptos.DisplayMember = "usuario";
            cbInscriptos.ValueMember = "id_usuario";
            cbInscriptos.SelectedIndex = -1;

        }

        //CARGAR COMBOS RESPONSABLE
        public void CargarComboResponable()
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

            cbResponsables.DataSource = datos;
            cbResponsables.DisplayMember = "usuario";
            cbResponsables.ValueMember = "id_usuario";
            cbResponsables.SelectedIndex = -1;

        }

        public void verificarCampos(ComboBox combo1, ComboBox combo2, ComboBox combo3)
        {
            if (combo1.SelectedValue is null)
            {
                combo1.Text = "Todos";
            }
            if (combo2.SelectedValue is null)
            {
                combo2.Text = "Todos";
            }
            if (combo3.SelectedValue is null)
            {
                combo3.Text = "Todos";
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
