using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2.Cap03.Bruno
{
    internal class Nome
    {
        public string ExibirNome(string PrimeiroNome)
        {
            return PrimeiroNome;
        }

        public string ExibirNome(string PrimeiroNome, string MeioNome)
        {
            return PrimeiroNome + ", " + MeioNome;
        }

        public string ExibirNome(string PrimeiroNome, string MeioNome, string FinalNome)
        {
            return PrimeiroNome + ", " + MeioNome + ", " + FinalNome;
        }
    }
}
