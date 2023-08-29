using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioA.Delegates.Bruno
{
    internal class Circulo
    {
        public delegate void Perimetro(int raio);

        public void CalculoPerimetro(int raio)
        {
            Console.WriteLine("O valor do perímetro do círculo é de: {0}cm", 2 * 3.14 * raio);
        }
    }
}
