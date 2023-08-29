using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioB.Delegate.Bruno
{
    internal class Soma
    {
        public delegate void Somar(double a, double b);

        public static void Somando(double a, double b)
        {
            Console.WriteLine("A soma de {0} e de {1} é igual a {2}", a, b, a + b);
        }
    }
}
