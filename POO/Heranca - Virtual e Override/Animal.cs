using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca___Virtual_e_Override
{
    //Classe base
    class Animal
    {
        public string? Nome { get; set; }
        public virtual void ExibeNome()
        {
            Console.WriteLine($"\nMeu nome é {Nome}");
        }
    }
}
