using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioB.Delegate.Bruno
{
    internal class Subtracao
    {
        public delegate void Subtrair(double a, double b);

        public static void Subtraindo(double a, double b)
        {
            Console.WriteLine("A subtração de {0} com {1} é igual a {2}", a, b, a - b);
        }
    }
}
