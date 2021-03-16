using System;

namespace pract_4_eje_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.MinValue;
            int y;
            int z=0;
            do
            {
                Console.WriteLine("inserte un numero");
                y = int.Parse(Console.ReadLine());
                if (y > x)
                {
                    x = y;
                }
                z++;
            } while (z < 10);

            Console.WriteLine("El mayor es: "+x);
            Console.ReadKey();
        }
    }
}
