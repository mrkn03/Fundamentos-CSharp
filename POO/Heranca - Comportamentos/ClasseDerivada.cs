using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca___Comportamentos
{
    class ClasseDerivada : ClasseBase
    {
        public void VerificarAcesso()
        {
            Public_Membro();
            Protected_Membro();
            Internal_Membro();
            ProtectedInternal_Membro();
            // Private_Membro(); // Erro de compilação

            Console.WriteLine("\nAcesso ao campo private: private_var usando o get da propriedade");
            int soma = public_var + protected_var + internal_var + Private_var;
            Console.WriteLine("Soma dos campos: " + soma);
        }
    }
}
