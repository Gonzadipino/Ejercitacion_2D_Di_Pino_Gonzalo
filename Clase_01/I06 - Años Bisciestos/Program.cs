using System;

namespace I06___Años_Bisciestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDeInicio;
            int numeroFinal;

            Console.WriteLine("Ingrese un numero de inicio:");
            while (!int.TryParse(Console.ReadLine(), out numeroDeInicio))
            {
                Console.WriteLine("Error. reingrese un numero valido: ");
            }

            Console.WriteLine("Ingrese un numero final:");
            while (!int.TryParse(Console.ReadLine(), out numeroFinal))
            {
                Console.WriteLine("Error. reingrese un numero valido: ");
            }

            for(int i = numeroDeInicio; i < numeroFinal; i++)
            {
                if(i%4 == 0 && i%100 != 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    if(i%100 == 0 && i%400 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }
    }
}
