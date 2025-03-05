using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo___Agregacao_e_Composicao
{
    class Sardinha : Animal
    {
        private readonly ComportamentoNadar _comportamentoNadar;

        public Sardinha(ComportamentoNadar comportamentoNadar)
        {
            Console.WriteLine(nameof(Sardinha));
            _comportamentoNadar = comportamentoNadar;
        }

        public void Locomocao()
        {
            _comportamentoNadar.Nadar();
        }
    }
}
