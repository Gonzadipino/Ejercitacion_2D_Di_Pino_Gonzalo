using System;

namespace I03___Los_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numeroPrimo;
            string cadena;
            int numero;
            do
            {
                Console.Clear();

                Console.WriteLine("Ingrese un numero: ");
                cadena = Console.ReadLine();
                while (int.TryParse(cadena, out numero) == false)
                {
                    Console.WriteLine("Error. Ingrese un numero valido o tipee 'salir' para terminar el programa: ");
                    cadena = Console.ReadLine();

                    if (cadena == "salir")
                        break;
                }

                Console.Clear();
                Console.WriteLine($"Numero primos hasta el {numero}: ");

                for (int i = 1; i <= numero; i++)
                {
                    if (i == 2 || i == 3 || i == 5 || i == 7 || i == 11)
                    {
                        Console.WriteLine(i);
                    }

                    if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 && i % 11 != 0)
                    {
                        Console.WriteLine(i);
                    }

                }

                if (cadena != "salir")
                {
                    Console.WriteLine("Toque cualquier tecla para volver a realizar la operacion o tipee 'salir' para finalizar el programa. . .");
                    cadena = Console.ReadLine();
                }

            } while (cadena.ToLower() != "salir");
        }
    }
}
