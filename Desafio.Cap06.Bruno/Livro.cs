using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Cap06.Bruno
{
    internal class Livro
    {
        public IAcervo DadosLivro { get; set; }

        public string Titulo
        {
            get => DadosLivro.Titulo;
            set => DadosLivro.Titulo = value;
        }

        public string Registro
        {
            get => DadosLivro.Registro;
            set => DadosLivro.Registro = value;
        }

        public string NumeroPag
        {
            get => DadosLivro.NumeroPag;
            set => DadosLivro.NumeroPag = value;
        }

        public string Autor
        {
            get => DadosLivro.Autor; 
            set => DadosLivro.Autor = value;
        }

        public string Editora
        {
            get => DadosLivro.Editora; 
            set => DadosLivro.Editora = value;
        }

        public string Mostrar()
        {
            return DadosLivro.MostrarDados();
        }
    }
}
