using System;
using System.Collections.Generic;

namespace pract_4_eje_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombre = new List<string>();
            Dictionary<string, string> buscarnombre = new Dictionary<string, string>();
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU DE GALERIA FOTOGRAFICA");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("1) Agregar fichero");
                Console.WriteLine("2) Ver todos los ficheros");
                Console.WriteLine("3) Buscar fichero");
                Console.WriteLine("4) Salir");
                Console.Write("inserte opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (nombre.Count == 700)
                        { Console.WriteLine("MEMORIA LLENA"); }
                        else
                        {
                            Console.Write("Inserte el nombre del fichero: "); string nom = Console.ReadLine();
                            Console.Write("Inserte el ancho del fichero: "); int ancho = int.Parse(Console.ReadLine());
                            Console.Write("Inserte el alto del fichero: "); int alto = int.Parse(Console.ReadLine());
                            Console.Write("Inserte el tamaño del fichero(KB): "); int kb = int.Parse(Console.ReadLine());
                            nombre.Add("Nombre: " + nom + "\nTamaño: " + ancho + " X " + alto + "\nEspacio en memoria: " + kb + "KB");
                            buscarnombre.Add(nom, "Nombre: " + nom + "\nTamaño: " + ancho + " X " + alto + "\nEspacio en memoria: " + kb + "KB");
                            Console.WriteLine("AGREGADO");
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                        if (nombre.Count < 1)
                        {
                            Console.WriteLine("No hay ficheros");
                        }

                        else
                        {
                            foreach (var elemento in nombre)
                            {
                                Console.WriteLine(elemento);
                                Console.WriteLine("");
                            }
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        if (nombre.Count < 1)
                        { Console.WriteLine("No hay ficheros"); }
                        else
                        {
                            Console.Write("Inserte el nombre del fichero:");
                            string buscar = Console.ReadLine();
                            foreach (var elemento in buscarnombre)
                            {
                                if (buscar == elemento.Key)
                                { Console.WriteLine(elemento.Value); }
                                else { Console.WriteLine(""); }
                            }
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("Saliendo ...");
                        break;

                    default:
                        Console.WriteLine("no existe");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 4);

            Console.ReadKey();
        }
    }
}
