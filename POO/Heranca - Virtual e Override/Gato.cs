using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca___Virtual_e_Override
{
    class Gato : Animal
    {
        public override void ExibeNome()
        {
            Console.WriteLine($"\nEu sou um gato e meu nome é {Nome}");
        }
    }
}
