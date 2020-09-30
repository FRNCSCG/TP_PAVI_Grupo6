using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI.Entidades
{
    class AvanceCurso
    {
        private int id_usuario;
        private int id_curso;                
        private DateTime fin;
        private int porc_avance;

        public AvanceCurso()
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

        public DateTime Fin {
            get => fin;
            set => fin = value;
        }

        public int Porc_avance {
            get => porc_avance;
            set => porc_avance = value;
        }
    }
}
