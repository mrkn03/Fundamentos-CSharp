using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamento_de_Excecoes
{
    class TesteAsync
    {
        public Task MinhaTarefaAsync()
        {
            return Task.Run(() => {
                Task.Delay(2000);
                throw new Exception("Minha Exception...");
            });
        }
        public async void ChamaTarefaAsync()
        {
            await MinhaTarefaAsync();
        }
    }
}
