using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoAbril_2021
{
    class Prestamo
    {
        private Ejemplar ejemplar;
        private Socio socio;
        private String fecha_prestado;

        public Prestamo(Ejemplar ejemplar, Socio socio)
        {
            this.ejemplar = ejemplar;
            this.socio = socio;
            this.fecha_prestado = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"); ;
        }

        public string Fecha_prestado { get => fecha_prestado; set => fecha_prestado = value; }
        internal Ejemplar Ejemplar { get => ejemplar; set => ejemplar = value; }
        internal Socio Socio { get => socio; set => socio = value; }
    }
}
