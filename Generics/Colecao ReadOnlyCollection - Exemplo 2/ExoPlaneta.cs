using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao_ReadOnlyCollection___Exemplo_2
{
    class ExoPlaneta
    {
        public string? Nome { get; set; }
        public static List<ExoPlaneta> GetExoPlanetas()
        {
            return new List<ExoPlaneta>()
        {
          new ExoPlaneta() { Nome = "Proxima Centauri b" },
          new ExoPlaneta() { Nome = "Kleper 186-f" },
          new ExoPlaneta() { Nome = "Gliesi 1061-c" },
        };
        }
    }
}
