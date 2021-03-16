using System;

namespace pract_4_eje_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            Console.WriteLine("TABLA DE MULTIPLICAR");
            do
            {
                Console.WriteLine("inserte valor(teclea -1 para salir):");
                valor = int.Parse(Console.ReadLine());
                if (valor != -1)
                {
                    Console.Clear();
                    Console.WriteLine($"TABLA DEL {valor}");
                    for (int contador = 1; contador < 13; contador++)
                    {
                        Console.WriteLine($"{valor} X {contador} = " + (valor * contador));
                    }
                    Console.ReadKey();
                }

            } while (valor != -1);
            Console.WriteLine("saliendo ...");
            Console.ReadKey();
        }
    }
}
