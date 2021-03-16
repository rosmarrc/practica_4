using System;

namespace pract_4_eje_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduzca 5 numeros:");
            float[] numeros = new float[5];

            numeros[0] = float.Parse(Console.ReadLine());
            numeros[1] = float.Parse(Console.ReadLine());
            numeros[2] = float.Parse(Console.ReadLine());
            numeros[3] = float.Parse(Console.ReadLine());
            numeros[4] = float.Parse(Console.ReadLine());

            Console.WriteLine("datos introducidos(sentido contrario):");

            for(int contador=numeros.Length; contador>0; contador--)
            {
                Console.WriteLine(numeros[contador-1]);
            }

            Console.ReadKey();
        }
    }
}
