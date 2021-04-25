using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIngresoAbril_2021
{
    class Libro
    {
        private String nombre;
        private long codigoISBN;
        private String autor;
        private List<Ejemplar> ejemplares = new List<Ejemplar>();


        public Libro()
        {

        }

        public Libro(string nombre, long codigoISBN, string autor)
        {
            this.nombre = nombre;
            this.codigoISBN = codigoISBN;
            this.autor = autor;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public long CodigoISBN { get => codigoISBN; set => codigoISBN = value; }
        public string Autor { get => autor; set => autor = value; }
        internal List<Ejemplar> Ejemplares { get => ejemplares; set => ejemplares = value; }

        public void MenuLibro()
        {
            string respuesta;
            bool flag;
            int newValue;
            Console.WriteLine("      Menu Libro:"
                   + "\n---------------------------------"
               );
            Console.WriteLine("Libro: " + this.nombre);
            while (true)
            {
                Console.WriteLine(
                    "1) Agregar Ejemplares\n" +
                    "2) Consultar Ejemplares Disponibles\n" +
                    "3) Salir\n"
                );
                respuesta = Console.ReadLine();
                flag = int.TryParse(respuesta, out newValue);

                if (flag)
                {
                    if (newValue == 3)
                        break;
                    switch (newValue)
                    {
                        case 1:
                            AgregarEjemplar();
                            break;
                        case 2:
                            if (ConsultarEjemplaresDisponibles())
                                Console.WriteLine("Hay ejemplares disponibles.");
                            else
                                Console.WriteLine("No hay ejemplares disponibles.");
                            break;
                        default:
                            break;
                    }

                }
            }
        }
        public void AgregarEjemplar()
        {
            Ejemplar ejemplar = new Ejemplar();
            ejemplar.Libro = this;

            Console.WriteLine("Ingrese la edición del libro: ");
            ejemplar.Nro_edicion = long.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la ubicación");
            ejemplar.Ubicacion = Console.ReadLine();

            this.ejemplares.Add(ejemplar);
        }

        public Boolean ConsultarEjemplaresDisponibles()
        {   
            if(this.ejemplares.Count > 0)
                return true;

            return false;
        }

        public Ejemplar PrestarEjemplar()
        {   
            if(this.ejemplares.Count > 0)
            {
                Ejemplar ejemplar = this.ejemplares[0];
                this.ejemplares.RemoveAt(0);

                return ejemplar;
            }
            else
            {
                Console.WriteLine("No hay ejemplares disponibles para prestar.");
            }
            return null;
        }

        public void RegistrarEjemplar(Ejemplar ejemplar)
        {
            this.ejemplares.Add(ejemplar);
        }


        public Ejemplar MenuLibroSocio()
        {
            string respuesta;
            bool flag;
            int newValue;
            Console.WriteLine("      Menu Socio:"
                   + "\n---------------------------------"
               );
            Console.WriteLine("Libro: " + this.nombre);
            while (true)
            {
                Console.WriteLine(
                    "1) Consultar Ejemplares Disponibles\n" +
                    "2) Prestar Ejemplar\n" +
                    "3) Registrar Ejemplar Devuelto\n" +
                    "4) Salir\n"
                );
                respuesta = Console.ReadLine();
                flag = int.TryParse(respuesta, out newValue);

                if (flag)
                {
                    switch (newValue)
                    {
                        case 1:
                            if (ConsultarEjemplaresDisponibles())
                                Console.WriteLine("Hay ejemplares disponibles.");
                            else
                                Console.WriteLine("No hay ejemplares disponibles.");
                            break;
                        case 2:
                            return PrestarEjemplar();
                        case 3:
                            RegistrarEjemplar(null);
                            break;
                        case 4:
                            return null;
                        default:
                            break;
                    }

                }
            }
            return null;
        }


    }
}
