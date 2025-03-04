using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacao
{
    class Departamento
    {
        public string? Nome { get; set; }
        private List<Professor>? professores = new List<Professor>();

        public Departamento(string? nome)
        {
            Nome = nome;
            professores = new List<Professor>();
        }

        public void AdicionaProfessor(Professor professor)
        {
            professores?.Add(professor);
        }

        public void ListarProfessores()
        {
            Console.WriteLine($"\nDepartamento de : {Nome}");
            foreach (var professor in professores)
            {
                Console.WriteLine($"Nome: {professor.Nome}, Disciplina: {professor.Disciplina}");
            }
        }
    }
}
