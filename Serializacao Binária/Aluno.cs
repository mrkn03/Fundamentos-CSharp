using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacao_Binária
{
    [Serializable]
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        [NonSerialized]
        public int Idade;

        public Aluno(int id, string nome, string email, int idade)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Idade = idade;
        }
    }
}
