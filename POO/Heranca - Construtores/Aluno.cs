using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca___Construtores
{
    //Classe Derivada de Pessoa
    class Aluno : Pessoa
    {
        public Aluno() : base()
        {
            Console.WriteLine("Construtor da classe Aluno");
        }
        public Aluno(string nome) : base(nome)
        {
            Console.WriteLine("Construtor da classe Aluno com parâmetro");
        }
    }
}
