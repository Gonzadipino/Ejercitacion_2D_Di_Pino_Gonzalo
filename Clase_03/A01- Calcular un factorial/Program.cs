using System;

namespace A01__Calcular_un_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Ingrese un numero positivo:");
            while (int.TryParse(Console.ReadLine(), out numero) == false || numero < 0)
            {
                Console.WriteLine("Error, ingrese un numero positivo: ");
            }

            Console.WriteLine($"El factorial de {numero} es : {FactorizarNumero(numero)}");
        }

        public static int FactorizarNumero(int numero)
        {
            int retorno = numero;

            while (numero > 1)
            {
                numero--;
                retorno *= numero;
            }
            return retorno;
        }
    }
}
