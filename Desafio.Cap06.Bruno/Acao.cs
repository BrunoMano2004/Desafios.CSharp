using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Cap06.Bruno
{
    internal class Acao : IAcervo
    {
        public Acao() { }
        public string? Titulo { get; set; }
        public string? Registro { get; set; }
        public string? NumeroPag { get; set; }
        public string? Autor { get; set; }
        public string? Editora { get; set; }
    }
}
