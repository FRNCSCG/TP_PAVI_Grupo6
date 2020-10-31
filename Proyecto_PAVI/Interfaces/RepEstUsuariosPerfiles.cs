using Microsoft.Reporting.WinForms;
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
    public partial class RepEstUsuariosPerfiles : Form
    {
        public RepEstUsuariosPerfiles()
        {
            InitializeComponent();
        }

        private void RepEstUsuariosPerfiles_Load(object sender, EventArgs e)
        {

        }

        private void reportUP_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Perfil.obtenerGrafico();
            ReportDataSource ds = new ReportDataSource("graficoUsuariosPerfiles", tabla);
            this.reportUP.LocalReport.DataSources.Clear();
            this.reportUP.LocalReport.DataSources.Add(ds);
            this.reportUP.RefreshReport();
        }
    }
}
