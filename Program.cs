using System;

namespace pract_4_eje_8
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] altura = new float[5];
            float suma = 0;
            Console.WriteLine("PROMEDIO DE ALTURAS"+Environment.NewLine);
            for( int contador=0; contador <5; contador++)
            {
                Console.Write("Inserte la altura: ");
                altura[contador] = float.Parse(Console.ReadLine());
                suma = suma + altura[contador];
            }
            float promedio = suma / 5;
            Console.WriteLine($"Promedio de alturas: {promedio}");

            foreach(float elemento in altura)
            {
                if(elemento>promedio){
                    Console.WriteLine($"la altura {elemento} es mas alta que el promedio");
                }
                else
                {
                    Console.WriteLine($"la altura {elemento} es mas baja que el promedio");
                }
            }

            Console.ReadKey();

        }
    }
}
