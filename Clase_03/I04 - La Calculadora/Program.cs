using System;

namespace I04___La_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string datoUsuario;
            double primerOperando;
            double segundoOperando;
            string operador;

            double resultado;

            do
            {
                Console.WriteLine("Ingrese primer operando:");
                while(double.TryParse(Console.ReadLine(), out primerOperando) == false)
                {
                    Console.WriteLine("Error, reingrese primer operando. . .");
                }

                Console.WriteLine("Ingrese segundo operando:");
                while (double.TryParse(Console.ReadLine(), out segundoOperando) == false)
                {
                    Console.WriteLine("Error, reingrese segundo operando. . .");
                }

                Console.WriteLine("Ingrese operador (+ , - , * , /):");
                operador = Console.ReadLine();

                while (operador != "+" && operador != "-" && operador != "*" && operador != "/")
                {
                    Console.WriteLine("ERROR. Ingrese operador (+ , - , * , /):");
                    operador = Console.ReadLine();
                }

                Console.WriteLine("El resultado es: " + Calculadora.Calcular(primerOperando,segundoOperando,operador));

                Console.WriteLine("Para salir tipee 'salir' / presione enter para volver a realizar una operacion. . .");
                datoUsuario =Console.ReadLine().ToLower();
                Console.Clear();

            } while (datoUsuario != "salir"); 
        }
    }
}
/*Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.*/