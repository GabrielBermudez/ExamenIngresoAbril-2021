using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoAbril_2021
{
    class Socio
    {
        protected String nombre,apellido;
        protected long nroIdentifiacion;
        protected List<Ejemplar> ejemplares_retirados = new List<Ejemplar>();
        protected int cantidad_maxima;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public long NroIdentifiacion { get => nroIdentifiacion; set => nroIdentifiacion = value; }
        public int Cantidad_maxima { get => cantidad_maxima; set => cantidad_maxima = value; }
        internal List<Ejemplar> Ejemplares_retirados { get => ejemplares_retirados; set => ejemplares_retirados = value; }
        

        public Boolean ConsultarCupo()
        {
            if (ejemplares_retirados.Count <= cantidad_maxima)
                return true;
            return false;
        }

        public void PedirEjemplar(Ejemplar ejemplar)
        {
            ejemplares_retirados.Add(ejemplar);
        }

        public Ejemplar DevolverEjemplar(int indice)
        {
            if (this.ejemplares_retirados.Count > 0)
            {
                Ejemplar ejemplar = this.ejemplares_retirados[indice];
                this.ejemplares_retirados.RemoveAt(indice);

                return ejemplar;
            }
            else
            {
                Console.WriteLine("No hay ejemplares disponibles para devolver.");
            }
            return null;
        }
    
    
    }
}
