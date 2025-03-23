﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desserializacao_JSON
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Idade { get; set; }
        public Aluno()
        {
        }
        public Aluno(int id, string name, string email, int idade)
        {
            Id = id;
            Name = name;
            Email = email;
            Idade = idade;
        }
    }
}
