using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca___Conceito_e_Sintaxe
{
    class Pessoa
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public void Identificar()
        {
            Console.WriteLine($"{Nome} - {Email}");
        }
    }
}
