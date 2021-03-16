using System;

namespace pract_4_eje_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dias = new int[3];
            dias[0] = 30;
            dias[1] = 31;
            dias[2] = 28;

            string[] mes = new string[12];

            mes[0] = "ENERO";
            mes[1] = "FEBRERO";
            mes[2] = "MARZO";
            mes[3] = "ABRIL";
            mes[4] = "MAYO";
            mes[5] = "JUNIO";
            mes[6] = "JULIO";
            mes[7] = "AGOSTO";
            mes[8] = "SEPTIEMBRE";
            mes[9] = "OCTUBRE";
            mes[10] = "NOVIEMBRE";
            mes[11] = "DICIEMBRE";

            Console.WriteLine("MESES:");
            Console.WriteLine("1) ENERO"+"\n2) FEBRERO"+"\n3) MARZO"+"\n4) ABRIL"+"\n5) MAYO"+ "\n6) JUNIO"+"\n7) JULIO"+"\n8) AGOSTO"+"\n9) SEPTIEMBRE"+"\n10) OCTUBRE"+
                "\n11) NOVIEMBRE"+"\n12) DICIEMBRE");
            Console.WriteLine("Insterte el  numero del mes y dire cuantos dias tiene:");
            int meses = int.Parse(Console.ReadLine());

            if (mes[meses - 1] == "ENERO")
            {
                Console.WriteLine(mes[meses - 1] + " tiene " + dias[1] + " dias");
            }
            if (mes[meses - 1] == "MARZO")
            {
                Console.WriteLine(mes[meses - 1] + " tiene " + dias[1] + " dias");
            }
            if (mes[meses - 1] == "MAYO")
            {
                Console.WriteLine(mes[meses - 1] + " tiene " + dias[1] + " dias");
            }
            if (mes[meses - 1] == "JULIO")
            {
                Console.WriteLine(mes[meses - 1] + " tiene " + dias[1] + " dias");
            }
            if (mes[meses - 1] == "AGOSTO")
            {
                Console.WriteLine(mes[meses - 1] + " tiene " + dias[1] + " dias");
            }
            if (mes[meses - 1] == "OCTUBRE")
            {
                Console.WriteLine(mes[meses - 1] + " tiene " + dias[1] + " dias");
            }
            if (mes[meses - 1] == "DICIEMBRE")
            {
                Console.WriteLine(mes[meses - 1] + " tiene " + dias[1] + " dias");
            }
            if (mes[meses - 1] == "ABRIL")
            {
                Console.WriteLine(mes[meses - 1] + " tiene " + dias[0] + " dias");
            }
            if (mes[meses - 1] == "JUNIO")
            {
                Console.WriteLine(mes[meses - 1] + " tiene " + dias[0] + " dias");
            }
            if (mes[meses - 1] == "SEPTIEMBRE")
            {
                Console.WriteLine(mes[meses - 1] + " tiene " + dias[0] + " dias");
            }
            if (mes[meses - 1] == "NOVIEMBRE")
            {
                Console.WriteLine(mes[meses - 1] + " tiene " + dias[0] + " dias");
            }
            if (mes[meses - 1] == "FEBRERO")
            {
                Console.WriteLine(mes[meses - 1] + " tiene " + dias[2] + " dias");
            }





            Console.ReadKey();

        }
    }
}
