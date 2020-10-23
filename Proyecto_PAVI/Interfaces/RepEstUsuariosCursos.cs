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
    public partial class RepEstUsuariosCursos : Form
    {
        public RepEstUsuariosCursos()
        {
            InitializeComponent();
        }

        private void RepUsuariosCursos_Load(object sender, EventArgs e)
        {

            this.reportCU.RefreshReport();
        }

        private void reportCU_Load(object sender, EventArgs e)
        {
            mostrarTodos();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Curso.obtenerListadoReporte(fechaDesde.Value,fechaHasta.Value);
            ReportDataSource ds = new ReportDataSource("graficoUsuariosCursos", tabla);
            this.reportCU.LocalReport.DataSources.Clear();
            this.reportCU.LocalReport.DataSources.Add(ds);
            this.reportCU.RefreshReport();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            mostrarTodos();
        }
    
    
        private void mostrarTodos()
        {
            DataTable tabla = new DataTable();
            tabla = AD_Curso.obtenerListadoReporteTodos();
            ReportDataSource ds = new ReportDataSource("graficoUsuariosCursos", tabla);
            this.reportCU.LocalReport.DataSources.Clear();
            this.reportCU.LocalReport.DataSources.Add(ds);
            this.reportCU.RefreshReport();
        }


    }
}


//Select c.Nombre, COUNT(uc.id_usuario) as Cantidad FROM UsuariosCursos UC INNER JOIN Cursos c ON uc.id_curso = c.id_curso GROUP BY c.Nombre;

//Select c.Nombre, COUNT(uc.id_usuario) as Cantidad FROM UsuariosCurso UC INNER JOIN Cursos c ON UC.id_curso = c.id_curso WHERE UC.fecha_inicio BETWEEN '' AND '' GROUP BY c.Nombre