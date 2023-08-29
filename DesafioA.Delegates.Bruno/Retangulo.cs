using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioA.Delegates.Bruno
{
    internal class Retangulo
    {
        public delegate void Perimetro(int altura, int Base);

        public void CalculoPerimetro(int altura, int Base)
        {
            Console.WriteLine("O valor do perímetro do retângulo é de: {0}cm", 2 * (Base + altura));
        }
    }
}
