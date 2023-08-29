using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3.Cap03.Bruno
{
    internal class Valor
    {
        public static int Num;

        public static void AlterarValor(int valor)
        {
            Num = valor;
        }

        public static string ExibirValor()
        {
            return Convert.ToString(Num);
        }
    }
}
