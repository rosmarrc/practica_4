using System;

namespace pract_4_eje_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            string nombre;
            Console.WriteLine("VERIFICADOR DE EDAD");
            do
            {
                Console.Clear();
                Console.Write("Inserte el nombre(pulsa enter para salir): ");
                nombre = Console.ReadLine();
                if(nombre=="")
                { return; }
                Console.Write("inserte edad:");
                valor = int.Parse(Console.ReadLine());
                if (valor < 0)
                { Console.WriteLine("edad no valida"); }
                else if (valor >= 18)
                {
                    Console.WriteLine($"Datos introducidos: \nNombre: {nombre} \nEdad: {valor}" + Environment.NewLine);
                    Console.WriteLine($"Resultado: {nombre} es mayor de edad");
                }
                else
                {
                    Console.WriteLine($"Datos introducidos: \nNombre: {nombre} \nEdad: {valor}" + Environment.NewLine);
                    Console.WriteLine($"Resultado: {nombre} es menor de edad");
                }
                Console.ReadKey();

            } while (valor != -1);
            Console.WriteLine("saliendo ...");
            Console.ReadKey();
        }
    }
}
