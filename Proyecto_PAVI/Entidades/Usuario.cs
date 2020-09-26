using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI.Entidades
{
    class Usuario
    {
        private string user;
        private string contraseña;

        public Usuario()
        {
        }

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
