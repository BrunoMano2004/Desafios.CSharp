using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Cap05.Bruno
{
    internal class Cursos : Treinamentos
    {
        public short IdTreinamento { get; set; }
        public string? NomeTreinamento { get; set; }
        public Cursos()
        {
            IdTreinamento = 0;
            NomeTreinamento = "Treinamento Genérico";
        }
        public void SetTreinamento(string nome, short id)
        {
            this.IdTreinamento = id;
            this.NomeTreinamento = nome;
        }

        public override string GetTreinamento()
        {
            return string.Format("Id treinamento: {0}\nNome treinamento: {1}", IdTreinamento.ToString(), NomeTreinamento);
        }
    }
}
