using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoAbril_2021
{
    class Ejemplar
    {
        private Libro libro;
        private long nro_edicion;
        private String ubicacion;

        public long Nro_edicion { get => nro_edicion; set => nro_edicion = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        internal Libro Libro { get => libro; set => libro = value; }
    }
}
