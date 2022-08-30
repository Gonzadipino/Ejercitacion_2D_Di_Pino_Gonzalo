using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace I03___Conversor_binario
{
    internal class Conversor
    {
        public string ConvertirDeciamalABinario(int numeroEntero)
        {
            string retorno = "";
            bool signo = false; //falso porque no lleva signo negativo

            if (numeroEntero < 0) //chequeo si es postivio o negativo, de no ser positivo lo obligo a serlo
            {
                signo = true;
                numeroEntero = numeroEntero * (-1);
            }

            if (numeroEntero >= 0)
            {
                do
                {
                    retorno = numeroEntero % 2 + retorno;
                    numeroEntero /= 2;
                } while (numeroEntero > 0);
            }

            if (signo) // agrego el signo negativo si el parametro recibido era negativo
            {
                retorno = "-" + retorno;
            }

            return retorno;
        }

        public string ConvertirDeciamalABinario(int numeroEntero)
        {

        }
    }
}
