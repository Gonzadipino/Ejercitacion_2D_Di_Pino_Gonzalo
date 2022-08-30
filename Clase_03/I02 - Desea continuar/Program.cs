using System;
using I01_Validador_De_Rangos;

namespace I02___Desea_continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char rta = 'N';
            int acum = 0;
            int numero;

            do
            {

                Console.Clear();
                Console.WriteLine("Ingrese un numero:");

                while (int.TryParse(Console.ReadLine(), out numero) == false)
                {
                    Console.Clear();
                    Console.WriteLine("Error. Ingrese un numero valido:");
                }
                acum = acum + numero;

                do
                {
                    Console.WriteLine("Desea Continuar? Al finalizar, todos los numeros ingresados se sumaran. S/N");
                    rta = Convert.ToChar(Console.ReadLine().ToUpper());

                } while (Validador.ValidarRespuesta(rta) == false);


            } while (rta == 'S');

            Console.WriteLine($"La suma total del acumulador es: {acum}");
            Console.ReadKey();
        }
    }
}
