using System;

namespace Clase_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int max = 0;
            int min = 0;
            float acum = 0;
            bool flag = true;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");

                while (int.TryParse(Console.ReadLine(), out numero) == false)
                {
                    Console.WriteLine("Error. Ingrese un numero valido: ");
                }
                acum = acum + numero;
                if (numero >= max || flag)
                    max = numero;
                if (numero <= min || flag)
                    min = numero;
                flag = false;
                Console.Clear();
            }
            Console.WriteLine($"El numero mas grande fue: {max}\n" +
                              $" El numero mas chico fue: {min} \n" +
                              $" El promedio es: {acum / 5}");
            Console.ReadKey();
        }

    }
}
