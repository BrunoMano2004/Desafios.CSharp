using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioB.Delegate.Bruno
{
    internal class Divisao
    {
        public delegate void Dividir(double a, double b);

        public static void Dividindo(double a, double b)
        {
            Console.WriteLine("A divisão de {0} com {1} é igual a: {2}", a, b, a / b);
        }
    }
}
