using System;

namespace I04___Un_numero_perfecto
{
    internal class Program
    {


        static void Main(string[] args)
        {
            double numeroPerfecto;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 != 0)
                {
                    numeroPerfecto = Math.Pow(2, i - 1) * (Math.Pow(2, i) - 1);
                    Console.WriteLine(numeroPerfecto);
                }
            }
        }
    }
}
