using System;

namespace pract_4_eje_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inroduce 4 numeros y mostrare la mmedia aritmetica");

            double[] numeros = new double[4];

            numeros[0] = double.Parse(Console.ReadLine());
            numeros[1] = double.Parse(Console.ReadLine());
            numeros[2] = double.Parse(Console.ReadLine());
            numeros[3] = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Datos introducidos");

            double suma = 0;
            for (int contador = 0; contador < numeros.Length; contador++)
            {
                Console.WriteLine(numeros[contador]);
                suma = suma + numeros[contador];
            }
            double media = suma / (numeros.Length);
            Console.WriteLine("La media aritmetica es: "+ media);

            Console.ReadKey();
           

           
        }
    }
}
