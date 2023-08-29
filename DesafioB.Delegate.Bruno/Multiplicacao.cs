using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioB.Delegate.Bruno
{
    internal class Multiplicacao
    {
        public delegate void Multiplicar(double a, double b);

        public static void Multiplicando(double a, double b)
        {
            Console.WriteLine("A multiplicação de {0} com {1} é igual a {2}", a, b, a * b);
        }
    }
}
