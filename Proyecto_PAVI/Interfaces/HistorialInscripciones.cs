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
    public partial class HistorialInscripciones : Form
    {
        public HistorialInscripciones()
        {
            InitializeComponent();
        }

        private void HistorialInscripciones_Load(object sender, EventArgs e)
        {

            CargarGrilla();
        }


        private void CargarGrilla()
        {
            dgvHistorial.DataSource = AD_HistorialInscripcion.obtenerListado();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
