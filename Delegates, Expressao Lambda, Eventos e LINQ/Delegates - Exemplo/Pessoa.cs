using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates___Exemplo
{
    class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string? nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public static List<Pessoa> GetPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>
            {
                new Pessoa("João", 20),
                new Pessoa("Maria", 18),
                new Pessoa("Pedro", 25),
                new Pessoa("Carlos", 15),
                new Pessoa("Ana", 17),
            };
            return pessoas;
        }
    }
}
