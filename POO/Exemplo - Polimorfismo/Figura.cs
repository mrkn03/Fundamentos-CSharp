using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo___Polimorfismo
{
    class Figura
    {
        public virtual void Desenhar()
        {
            Console.WriteLine("Executando Desenhar() na classe base");
        }
    }
}
