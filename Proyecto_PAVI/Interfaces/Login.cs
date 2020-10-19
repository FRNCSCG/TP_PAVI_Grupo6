using Proyecto_PAVI.AccesoBD;
using Proyecto_PAVI.Entidades;
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
    public partial class Login : Form
    {

        
        public Login()
        {
            InitializeComponent();
        }

        Usuario usuario = new Usuario();

        public static string usuarioActual;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        //CARGAR USUARIO APARTIR DE LOS TEXTBOXS
        public Usuario  cargarUsuario(TextBox txtUsuario,TextBox txtContraseña)
        {            
            usuario.User = txtUsuario.Text;
            usuario.Contraseña = txtContraseña.Text;
            return usuario;
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtContraseña.Text.Equals(""))
            {
                MessageBox.Show("Por favor,complete los datos necesarios para ingresar");
            }
            else
            {
                Usuario usuario = cargarUsuario(txtUsuario, txtContraseña);
                usuarioActual = usuario.User;

                bool var = AD_Usuario.validar_usuario(usuario.User ,usuario.Contraseña );
                if (var)
                {
                    this.Hide();
                }
                else
                {                    
                    MessageBox.Show("Usuario y/o contraseña ingresada incorrecto");                    
                }
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            Usuario usuario = cargarUsuario(txtUsuario, txtContraseña);
            usuarioActual = usuario.User;

            bool var = AD_Usuario.validar_usuario(usuario.User, usuario.Contraseña);
            if (var)
            {
            this.Hide();
            }
                
            
        }
    }
}
