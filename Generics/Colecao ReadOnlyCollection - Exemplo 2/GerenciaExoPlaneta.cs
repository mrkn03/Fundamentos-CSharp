using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao_ReadOnlyCollection___Exemplo_2
{
    class GerenciaExoPlaneta
    {
        private List<ExoPlaneta>? exoPlanetas = ExoPlaneta.GetExoPlanetas();

        public ReadOnlyCollection<ExoPlaneta> ExoPlanetas
        {
            get { return exoPlanetas.AsReadOnly(); }
        }
        public void AdicionaPlaneta(ExoPlaneta planeta)
        {
            exoPlanetas.Add(planeta);
        }
    }
}
