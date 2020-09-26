using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI.Entidades
{
   public  class Categoria
    {
        private int id_cat;
        private string nombre;
        private string descripcion;
        private int borrado;

        public Categoria()
        {
        }

        public int Id_cat {
            get => id_cat;
            set => id_cat = value;
        }

        public string Nombre {
            get => nombre;
            set => nombre = value;
        }

        public string Descripcion {
            get => descripcion;
            set => descripcion = value;
        }

        public int Borrado {
            get => borrado;
            set => borrado = value; }
    }
}
