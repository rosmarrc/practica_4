using System;

namespace pract_4_eje_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres;
            int x;
            do
            {
                Console.WriteLine("cuantos nombres va a introducir?");
                x = int.Parse(Console.ReadLine());
            } while (x>100 );
            nombres = new string[x];


            for (int y = 0; y < x; y++)
            {
                Console.WriteLine("introduzca un nombre:");
                nombres[y] = Console.ReadLine();
            }
           
            Console.Clear();
            Console.WriteLine("Listado de nombres introducidos");

            foreach(string elemento in nombres)
            {
                Console.WriteLine(elemento);               
            }
            Console.ReadKey();
        }
    }
}
