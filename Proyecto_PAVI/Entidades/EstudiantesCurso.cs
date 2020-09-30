using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI.Entidades
{
    class EstudiantesCurso
    {
        private int id_usuario;
        private int id_curso;
        private int puntuacion;
        private string observaciones;
        private DateTime  fecha_inicio;
        private DateTime fecha_fin;

        public EstudiantesCurso()
        {
        }

        public int Id_usuario {
            get => id_usuario;
            set => id_usuario = value;
        }

        public int Id_curso {
            get => id_curso;
            set => id_curso = value;
        }

        public int Puntuacion {
            get => puntuacion;
            set => puntuacion = value;
        }

        public string Observaciones {
            get => observaciones;
            set => observaciones = value;
        }

        public DateTime Fecha_inicio {
            get => fecha_inicio;
            set => fecha_inicio = value;
        }

        public DateTime Fecha_fin {
            get => fecha_fin;
            set => fecha_fin = value;
        }
    }
}
