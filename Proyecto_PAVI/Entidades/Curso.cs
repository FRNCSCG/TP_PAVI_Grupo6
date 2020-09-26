using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI.Entidades
{
    public class Curso
    {
        private int id_curso;
        private string nombre;
        private string descripcion;
        private DateTime fecha_vigencia;
        private int id_categoria;
        private int borrado;

        public Curso()
        {
        }

        public int Id_curso {
            get => id_curso;
            set => id_curso = value;
        }

        public string Nombre {
            get => nombre;
            set => nombre = value; }

        public string Descripcion {
            get => descripcion;
            set => descripcion = value; }

        public DateTime Fecha_vigencia {
            get => fecha_vigencia;
            set => fecha_vigencia = value; }

        public int Id_categoria {
            get => id_categoria;
            set => id_categoria = value; }

        public int Borrado {
            get => borrado;
            set => borrado = value;
        }

    }
}
