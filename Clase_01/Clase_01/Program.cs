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
            bool flag = true;
            float acum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");

                while (int.TryParse(Console.ReadLine(), out numero) == false)
                {
                    Console.WriteLine("Error. Ingrese un numero valido: ");
                }
                acum = acum + numero;
                if (flag)
                {
                    min = numero;
                    max = numero;
                    flag = false;
                }

                max = Math.Max(numero, max);
                min = Math.Min(min, numero);

                Console.Clear();
            }
            Console.WriteLine($"El numero mas grande fue: {max}\n" +
                              $" El numero mas chico fue: {min} \n" +
                              $" El promedio es: {acum / 5}");
            Console.ReadKey();
        }

    }
}
