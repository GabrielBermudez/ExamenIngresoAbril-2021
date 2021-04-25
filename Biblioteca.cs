using System;
using System.Collections.Generic;

namespace ExamenIngresoAbril_2021
{
    class Biblioteca
    {
        static void Main(string[] args)
        {   
            

            List<Libro> lista_libros = new List<Libro>();
            List<Socio> lista_socios = new List<Socio>();

            Libro libro_harryPotter1 = new Libro("Harry Potter 1", 345, "Rowling");
            Libro libro_harryPotter2 = new Libro("Harry Potter 2", 346, "Rowling");
            Libro libro_harryPotter3 = new Libro("Harry Potter 3", 347, "Rowling");

            lista_libros.Add(libro_harryPotter1);
            lista_libros.Add(libro_harryPotter2);
            lista_libros.Add(libro_harryPotter3);

            while (true)
            {
                string respuesta;
                bool flag;
                int newValue;
                Console.WriteLine("      Biblioteca Hanami"
                    + "\n---------------------------------"
                );
                Console.WriteLine(
                    "1) Libros\n" +
                    "2) Socios\n" +
                    "3) Salir\n"
                );
                respuesta = Console.ReadLine();
                flag = int.TryParse(respuesta, out newValue);

                if (flag)
                {
                    switch (newValue)
                    {
                        case 1:
                            MostrarLibros(lista_libros);
                            break;
                        case 2:
                            MenuSocios(lista_socios, lista_libros);
                            break;
                        case 3:
                            Environment.Exit(1);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public static void MostrarLibros(List<Libro> lista_libros)
        {
            
            while (true)
            {
                int aux = 0;
                string respuesta;
                bool flag;
                int newValue;
                Console.WriteLine("ID |      Nombre      |   Codigo ISBN   |   Autor    | Ejemplares");
                foreach (Libro libro in lista_libros)
                {
                    aux++;
                    Console.WriteLine(
                        aux + "  |  " +
                        libro.Nombre + "  |  " +
                        "       " + libro.CodigoISBN + "     |  " +
                        libro.Autor + "   |   " +
                        "   " + libro.Ejemplares.Count
                        );
                }
                Console.WriteLine((aux + 1) + ") Salir");
                Console.Write("Ingrese el ID del Libro: \n");
                respuesta = Console.ReadLine();
                flag = int.TryParse(respuesta, out newValue);
                if (flag && newValue > 0 && newValue < (aux+1))
                {
                    lista_libros[newValue-1].MenuLibro();

                }else if (newValue == (aux+1))
                {
                    break;
                }
            }
        }

        public static Ejemplar MostrarLibrosSocio(List<Libro> lista_libros)
        {
            while (true)
            {
                int aux = 0;
                string respuesta;
                bool flag;
                int newValue;
                Console.WriteLine("ID |      Nombre      |   Codigo ISBN   |   Autor    | Ejemplares");
                foreach (Libro libro in lista_libros)
                {
                    aux++;
                    Console.WriteLine(
                        aux + "  |  " +
                        libro.Nombre + "  |  " +
                        "       " + libro.CodigoISBN + "     |  " +
                        libro.Autor + "   |   " +
                        "   " + libro.Ejemplares.Count
                        );
                }
                Console.WriteLine((aux + 1) + ") Salir");
                Console.Write("Ingrese el ID del Libro: \n");
                respuesta = Console.ReadLine();
                flag = int.TryParse(respuesta, out newValue);
                if (flag && newValue > 0 && newValue < (aux + 1))
                {
                    return lista_libros[newValue - 1].MenuLibroSocio();

                }
                else if (newValue == (aux + 1))
                {
                    break;
                }
            }

            return null;
        }


        public static void MenuSocios(List<Socio> socios, List<Libro> libros)
        {
            while (true)
            {
                string respuesta;
                bool flag;
                int newValue;
                Console.WriteLine(
                    "1) Dar de alta socio\n"+
                    "2) Dar de alta socio vip\n"+
                    "3) Mostrar socios\n"+
                    "4) Salir"
                    );
                respuesta = Console.ReadLine();
                flag = int.TryParse(respuesta, out newValue);

                if (newValue == 4)
                    break;

                if (flag)
                {
                    switch (newValue)
                    {
                        case 1:
                            socios.Add(AltaSocio());
                            break;
                        case 2:
                            socios.Add(AltaSocioVip());
                            break;
                        case 3:
                            int indice_socio = MostrarSocios(socios);
                            if(indice_socio >= 0)
                                MenuSocio(socios[indice_socio],libros);
                            break;
                          
                        default:
                            break;
                    }
                }
            }

        }

        public static Socio AltaSocio()
        {
            Socio socio = new Socio();

            Console.Write("Ingrese el nombre: ");
            socio.Nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido: ");
            socio.Apellido = Console.ReadLine();

            Console.Write("Ingrese el número de identificación: ");
            socio.NroIdentifiacion = long.Parse(Console.ReadLine());

            socio.Cantidad_maxima = 3;

            return socio;
        }

        public static SocioVip AltaSocioVip()
        {
            SocioVip socioVip = new SocioVip();

            Console.Write("Ingrese el nombre: ");
            socioVip.Nombre = Console.ReadLine();

            Console.Write("Ingrese el apellido: ");
            socioVip.Apellido = Console.ReadLine();

            Console.Write("Ingrese el número de identificación: ");
            socioVip.NroIdentifiacion = long.Parse(Console.ReadLine());

            Console.Write("Ingrese la cuota mensual a cobrar: ");
            socioVip.Cuota_mensual = Double.Parse(Console.ReadLine());

            socioVip.Cantidad_maxima = 15;

            return socioVip;
        }

        public static int MostrarSocios(List<Socio> socios)
        {
            while (true)
            {
                int aux = 0;
                string respuesta;
                bool flag;
                int newValue;
                if (socios.Count > 0)
                {
                    Console.WriteLine("ID |   Nombre   |   Apellido   | Número de identificación | Cantidad Maxima | Cuota Mensual | ¿Es Vip?  | Ejemplares en posesión");
                    foreach (Socio socio in socios)
                    {
                        aux++;
                        if (socio.GetType() == typeof(Socio))
                        {
                            Console.WriteLine(
                               aux + "   |   " +
                               socio.Nombre + "   | " +
                               socio.Apellido + "     |      " +
                               "    " + socio.NroIdentifiacion + "      |      " +
                               "    " + socio.Cantidad_maxima + "      |      " +
                                "    " + "No" + "   |   " +
                                "    " + "No" + "   |   " +
                                "    " + socio.Ejemplares_retirados.Count
                                );

                        }
                        else if (socio.GetType() == typeof(SocioVip))
                        {
                            SocioVip socioVip = (SocioVip)socio;
                            Console.WriteLine(
                               aux + "   | " +
                               socioVip.Nombre + "   | " +
                               socioVip.Apellido + "     |      " +
                               "    " + socioVip.NroIdentifiacion + "      |      " +
                               "    " + socioVip.Cantidad_maxima + "      |      " +
                               "    " + socioVip.Cuota_mensual + "      |     " +
                               "    " + "Si" + "   |   " +
                               "    " + socio.Ejemplares_retirados.Count
                               );
                        }
                    }
                    Console.WriteLine((aux + 1) + ") Salir");
                    Console.Write("Ingrese el ID del Socio: \n");
                    respuesta = Console.ReadLine();
                    flag = int.TryParse(respuesta, out newValue);
                    if (flag && newValue > 0 && newValue < (aux + 1))
                    {
                        return (newValue - 1);
                        break;
                    }
                    else if (newValue == (aux + 1))
                        break;
                }
                else {
                    Console.WriteLine("No hay socios registrados.");
                    break;
                }
            }
            return -1;
        }

        public static void MenuSocio(Socio socio, List<Libro> libros)
        {
            while (true)
            {
                string respuesta;
                bool flag;
                int newValue;
                Console.WriteLine(
                    "1) Consultar cupo disponible\n" +
                    "2) Pedir prestado ejemplar\n" +
                    "3) Devolver ejemplar\n" +
                    "4) Salir"
                    );
                respuesta = Console.ReadLine();
                flag = int.TryParse(respuesta, out newValue);

                if (newValue == 4)
                    break;

                if (flag)
                {
                    switch (newValue)
                    {
                        case 1:
                            if (socio.ConsultarCupo())
                                Console.WriteLine("Posee cupo disponible.("+(socio.Cantidad_maxima-socio.Ejemplares_retirados.Count)+")");
                            else
                                Console.WriteLine("No posee cupo disponible.(" + (socio.Cantidad_maxima-socio.Ejemplares_retirados.Count) + ")");
                            break;
                        case 2:
                            Ejemplar ejemplar = MostrarLibrosSocio(libros);
                            if(ejemplar != null)
                                socio.PedirEjemplar(ejemplar);
                            break;
                        case 3:
                            int indice_ejemplar = MostrarEjemplares(socio);
                            if (indice_ejemplar > -1) {
                                foreach (Libro libro in libros)
                                {
                                    if (socio.Ejemplares_retirados[indice_ejemplar].Libro == libro)
                                    {
                                        libro.RegistrarEjemplar(socio.DevolverEjemplar(indice_ejemplar));
                                        break;
                                    }
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

        }

        public static int MostrarEjemplares(Socio socio)
        {
            while (true)
            {
                string respuesta;
                bool flag;
                int newValue;
                int aux = 0;
                Console.WriteLine(
                    "    ID       |   Libro        |   Nro. Edición   |   Ubicación   "
                    );
                foreach (Ejemplar ejemplar in socio.Ejemplares_retirados)
                {
                    aux++;
                    Console.WriteLine(
                        aux + "   |   " +
                        ejemplar.Libro.Nombre + "   |   " +
                        ejemplar.Nro_edicion + "   |   " +
                        ejemplar.Ubicacion + "   |   " 
                        );
                }
                Console.Write("Ingrese el ID del libro a devolver: ");
                respuesta = Console.ReadLine();
                flag = int.TryParse(respuesta, out newValue);

                if (flag)
                {
                    if (newValue == aux + 1)
                        break;
                    return newValue - 1;

                }
            }

            return -1;
        }
    }
}
