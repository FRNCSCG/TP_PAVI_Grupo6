using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI.Entidades
{
    class Usuario
    {
        private int id_usuario;
        private string user;
        private string contraseña;

        public Usuario()
        {
        }
        
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        
        public string User {
            get => user;
            set => user = value;
        }

        public string Contraseña {
            get => contraseña;
            set => contraseña = value;
        }
        
    }
}
