using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_PAVI.AccesoDatos;

namespace Proyecto_PAVI.Interfaces
{
    public partial class RepEstActividadesInscripciones : Form
    {
        public RepEstActividadesInscripciones()
        {
            InitializeComponent();
        }


        private void RepEstActividadesInscripciones_Load(object sender, EventArgs e)
        {
           
        }

        private void reportAI_Load(object sender, EventArgs e)
        {
            mostrarTodos();
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_HistorialInscripcion.obtenerGrafico(fechaDesde.Value, fechaHasta.Value);
            ReportDataSource ds = new ReportDataSource("graficoActividadesInscripciones", tabla);
            this.reportAI.LocalReport.DataSources.Clear();
            this.reportAI.LocalReport.DataSources.Add(ds);
            this.reportAI.RefreshReport();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            mostrarTodos();
        }


        private void mostrarTodos()
        {
            DataTable tabla = new DataTable();
            tabla = AD_HistorialInscripcion.obtenerGraficoTodos();
            ReportDataSource ds = new ReportDataSource("graficoActividadesInscripciones", tabla);
            this.reportAI.LocalReport.DataSources.Clear();
            this.reportAI.LocalReport.DataSources.Add(ds);
            this.reportAI.RefreshReport();
        }





    }
}
