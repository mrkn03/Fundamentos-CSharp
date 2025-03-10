using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary___Exemplo
{
    class Aluno
    {
        protected string? Nome { get; set; }
        protected int Nota { get; set; }

        public Aluno(string nome, int nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public string GetNome()
        {
            return Nome;
        }

        public double GetNota()
        {
            return Nota;
        }

        public void SetNota(int nota)
        {
            Nota = nota;
        }

    }
}
