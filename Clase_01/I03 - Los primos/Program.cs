using System;

namespace I03___Los_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int numero;
            do {
                Console.WriteLine("Ingrese un numero: ");
                cadena = Console.ReadLine();
                while (int.TryParse(cadena, out numero) == false)
                {
                    Console.WriteLine("Error. Ingrese un numero valido o tipee 'salir' para terminar el programa: ");
                    cadena = Console.ReadLine();
                    if (cadena == "salir")
                    {
                        break;
                    }
                }
                for (int i = 0; i < numero; i++)
                {
                    if ( i != 0 && i != 1 && i % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("Desea volver a ingresar un numero? S/N");
                cadena = Console.ReadLine();

            } while(cadena.ToLower() == "s");
        }
    }
}
