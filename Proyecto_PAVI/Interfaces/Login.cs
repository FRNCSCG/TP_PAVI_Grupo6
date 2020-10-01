﻿using Proyecto_PAVI.AccesoBD;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtContraseña.Text.Equals(""))
            {
                MessageBox.Show("Por favor,complete los datos necesarios para ingresar");
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.User = txtUsuario.Text;
                usuario.Contraseña = txtContraseña.Text;

                bool var = AD_Usuario.validar_usuario(usuario.User ,usuario.Contraseña );
                if (var)
                {
                    this.Hide();
                    MenuPrincipal pantMenuPrincipal = new MenuPrincipal();
                    pantMenuPrincipal.Show();

                }
                else
                {                    
                    MessageBox.Show("Usuario y/o contraseña ingresada incorrecto");                    
                }
            }
        }
    }
}