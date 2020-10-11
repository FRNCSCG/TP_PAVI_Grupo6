using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI.Entidades
{
    class HistorialInscripcion
    {
        private int id_historial;   // el id
        private string descripcion; //ejemplo "insert" o "update"
        private DateTime fecha; //fecha actividad
        private int id_inscripto; //id de Usuario inscripto
        private int id_curso; //id del curso
        private int id_responsable; //usuario actual

        public int Id_historial { get => id_historial; set => id_historial = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Id_responsable { get => id_responsable; set => id_responsable = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Id_inscripto { get => id_inscripto; set => id_inscripto = value; }
        public int Id_curso { get => id_curso; set => id_curso = value; }
    }
}
