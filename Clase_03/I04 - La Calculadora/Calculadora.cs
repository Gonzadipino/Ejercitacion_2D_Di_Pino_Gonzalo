using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I04___La_Calculadora
{
    internal class Calculadora
    {
        public static string Calcular(double primerOperando, double segundoOperando, string operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = primerOperando + segundoOperando;
                    break;
                case "-":
                    resultado = primerOperando - segundoOperando;
                    break;
                case "*":
                    resultado = primerOperando * segundoOperando;
                    break;
                case "/":
                    if (Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    else
                    {
                        return "No es posible dividir por 0. Syntax Error";
                    }
                    break;
            }

            return resultado.ToString();
        }
        private static bool Validar(double segundoOperando)
        {
            if (segundoOperando != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
