using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca___Construtores
{
    //Classe base   
    class Pessoa
    {
        public Pessoa()
        {
            Console.WriteLine("Construtor da classe Pessoa");
        }

        public Pessoa(string nome)
        {
            Console.WriteLine("Construtor da classe Pessoa com parâmetro");
        }
    }
}
