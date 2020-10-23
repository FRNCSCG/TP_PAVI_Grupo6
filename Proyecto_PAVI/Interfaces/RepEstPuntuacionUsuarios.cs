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
    public partial class RepEstPuntuacionUsuarios : Form
    {
        public RepEstPuntuacionUsuarios()
        {
            InitializeComponent();
        }

        private void ReporteEstPuntuacionUsuarios_Load(object sender, EventArgs e)
        {

            this.reportPU.RefreshReport();
        }


        private void reportPU_Load(object sender, EventArgs e)
        {
            mostrarTodos();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Usuario.obtenerListadoReporte(fechaDesde.Value, fechaHasta.Value);
            ReportDataSource ds = new ReportDataSource("graficoPuntuacionUsuarios", tabla);
            this.reportPU.LocalReport.DataSources.Clear();
            this.reportPU.LocalReport.DataSources.Add(ds);
            this.reportPU.RefreshReport();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            mostrarTodos();
        }

        private void mostrarTodos()
        {
            DataTable tabla = new DataTable();
            tabla = AD_Usuario.obtenerListadoReporteTodos();
            ReportDataSource ds = new ReportDataSource("graficoPuntuacionUsuarios", tabla);
            this.reportPU.LocalReport.DataSources.Clear();
            this.reportPU.LocalReport.DataSources.Add(ds);
            this.reportPU.RefreshReport();
        }


    }
}
