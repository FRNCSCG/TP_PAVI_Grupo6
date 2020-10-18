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
            this.reportesIns.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_HistorialInscripcion.obtenerListadoReporte ();
            ReportDataSource ds = new ReportDataSource("reporteInscripciones", tabla);
            reportesIns.LocalReport.DataSources.Clear();
            reportesIns.LocalReport.DataSources.Add(ds);
            reportesIns.LocalReport.Refresh();
        }
    }
}
