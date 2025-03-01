using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___List
{
    class Aluno
    {
        private string Nome { get; set; }
        private double Nota { get; set; }

        public Aluno()
        {
        }

        public Aluno(string nome, double nota)
        {
            this.Nome = nome;
            this.Nota = nota;
        }

        public string getNome()
        {
            return Nome;
        }

        public double getNota()
        {
            return Nota;

        }

        public static void MediaAritmetica(List<Aluno> alunos)
        {
            double soma = 0;
            foreach (Aluno aluno in alunos)
            {
                soma += aluno.getNota() / alunos.Count;

            }

            Console.WriteLine("Media aritmetica da turma: " + soma);
        }

        public static void ExibirAlunos(List<Aluno> alunos)
        {
            if (alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado");
            }

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine(aluno.ToString());
            }
        }

        public static bool ProcuraAluno(List<Aluno> alunos, string Nome)
        {
            foreach (var aluno in alunos)
            {
                if (aluno.getNome().Equals(Nome))
                {
                    return true;
                }
            }
            return false;
        }

        public static void RemoveAluno(List<Aluno> alunos, string Nome)
        {
            foreach (var aluno in alunos)
            {
                if (aluno.getNome().Equals(Nome))
                {
                    alunos.Remove(aluno);
                    break;
                }
            }
        }

        public override string ToString()
        {
            return "\nNome: " + Nome + " Nota: " + Nota;
        }

    }
}
