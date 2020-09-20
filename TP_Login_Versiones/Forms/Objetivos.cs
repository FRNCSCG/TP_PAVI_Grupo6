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

        Conexion oBD = new Conexion();
        public Objetivos()
        {
            InitializeComponent();
        }

        private void Objetivos_Load(object sender, EventArgs e)
        {
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
    }
}
