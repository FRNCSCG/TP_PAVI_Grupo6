using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Login_Versiones.Class
{
    class Categoria
    {
        private int id_categoria;
        private string nombre;
        private string descripcion;
        private int borrado;

        public int Id_categoria { get => id_categoria; set => id_categoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Borrado { get => borrado; set => borrado = value; }
    }
}
