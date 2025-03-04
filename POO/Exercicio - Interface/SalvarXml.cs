using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Interface
{
    class SalvarXml : ArquivoBase, ISalvar
    {
        public void Salvar()
        {
            throw new NotImplementedException();
        }

        public override void Nome()
        {
            Console.WriteLine("Definir noem XML");
        }
    }
}
