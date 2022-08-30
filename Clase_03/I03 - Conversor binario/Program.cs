using System;

namespace I03___Conversor_binario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int opcion;

            Console.WriteLine("Ingrese un numero:");
            while (int.TryParse(Console.ReadLine(), out numero) == false)
            {
                Console.Clear();
                Console.WriteLine("Error, ingrese un numero valido: ");
            }


            Console.WriteLine("Convertir a decimal? ----> 1");
            Console.WriteLine("Convertir a decimal? ----> 2");
            Console.ReadLine();
            while (int.TryParse(Console.ReadLine(), out opcion) == false && I01_Validador_De_Rangos.Validador.Validar(opcion, 1, 2) == false)
            {
                Console.WriteLine("Error, ingrese una opcion valida: ");
            }

        }
    }
}//incompleto
