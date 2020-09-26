using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_PAVI.Entidades
{
    public class Objetivo
    {
        private int id_objetivo;
        private string nombre_largo;
        private string nombre_corto;
        private int borrado;

        public Objetivo()
        {
        }

        public Objetivo(int id_objetivo, string nombre_largo, string nombre_corto, int borrado)
        {
            this.Id_objetivo = id_objetivo;
            this.Nombre_largo = nombre_largo;
            this.Nombre_corto = nombre_corto;
            this.Borrado = borrado;
        }

        public int Id_objetivo
        {
            get => id_objetivo;
            set => id_objetivo = value;
        }

        public string Nombre_largo
        {
            get => nombre_largo;
            set => nombre_largo = value;
        }

        public string Nombre_corto
        {
            get => nombre_corto;
            set => nombre_corto = value;
        }

        public int Borrado
        {
            get => borrado;
            set => borrado = value;
        }
    }
}
