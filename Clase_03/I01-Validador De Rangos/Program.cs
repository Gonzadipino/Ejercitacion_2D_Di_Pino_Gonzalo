using System;

namespace I01_Validador_De_Rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int max = 0;
            int min = 0;
            double acumulador = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero:\n");

                while (int.TryParse(Console.ReadLine(), out numero) == false | Validador.Validar(numero, -100, 100) == false)
                {
                    Console.Clear();
                    Console.WriteLine("Error. Ingrese un numero valido, entre -100 y 100:\n");
                }

                if (i == 0)
                {
                    max = numero;
                    min = numero;
                }
                acumulador += numero;
                max = Math.Max(numero, max);
                min = Math.Min(numero, min);

                Console.Clear();

            }
            Console.WriteLine($"El numero maximo es:{max}");
            Console.WriteLine($"El numero minimo es:{min}");
            Console.WriteLine($"El promedio es: {acumulador/10}");
        }
    }

}
