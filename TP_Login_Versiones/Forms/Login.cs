using TP_Login_Versiones.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Login_Versiones.Forms;

namespace TP_Login_Versiones
{
    public partial class frm_logueo : Form
    {
        Conexion conexion = new Conexion();
        public frm_logueo()
        {
            InitializeComponent();
        }

        private void frm_logueo_Load(object sender, EventArgs e)
        {
            txt_contraseña.PasswordChar = '*';
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            User USUARIO = new User(txt_usuario.Text , txt_contraseña.Text );
            bool var = conexion .VALIDAR_USUARIO(txt_usuario.Text, txt_contraseña.Text);
            if (var == true)
            {
                Principal pantPrinc = new Principal();
                pantPrinc.ShowDialog();
                this.Close();
            }
            
            
            //USER = new USUARIO(TB_USUARIO.Text, TB_CONTRASEÑA.Text);

            //bool var = conexion.VALIDAR_USUARIO(TB_USUARIO.Text, TB_CONTRASEÑA.Text);
            //if (var == true)
            //{
            //    PRINCIPAL pantPrinc = new PRINCIPAL();
            //    pantPrinc.ShowDialog();
            //    this.Close();
            //}
        }
    }
}
//Comentario de Ariel, Nahuel y Francisco