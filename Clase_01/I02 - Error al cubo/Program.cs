using System;

namespace I02___Error_al_cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un numero: ");
            while (int.TryParse(Console.ReadLine(), out numero) == false && numero <= 0)
            {
                Console.WriteLine("Error. Ingrese un numero valido: ");
            }
            Console.WriteLine($"El cuadrado del numero es: {Math.Pow(numero,2)}\n" +
                              $"El cubo del numero es: {Math.Pow(numero,3)}");
            Console.ReadKey();
        }
    }
}
