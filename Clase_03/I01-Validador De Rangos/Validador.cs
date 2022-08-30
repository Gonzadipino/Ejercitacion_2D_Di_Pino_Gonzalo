using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01_Validador_De_Rangos
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool ret = false;

            if (valor >= min && valor <= max)
            {
                ret = true;
            }
            return ret;
        }

        public static bool ValidarRespuesta(char letra)
        {
            bool ret = false;
            if (letra != 'S' || letra != 'N')
            {
                ret = true;
            }
            return ret;
        }
    }
}
