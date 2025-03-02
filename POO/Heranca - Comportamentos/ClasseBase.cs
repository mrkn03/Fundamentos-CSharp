using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca___Comportamentos
{
    class ClasseBase
    {
        //Campos
        public int public_var = 1;
        protected int protected_var = 2;
        internal int internal_var = 3;
        private int private_var = 4;

        //propriedade
        public int Private_var
        {
            get { return private_var; }
            set { private_var = value; }
        }

        public void Public_Membro()
        {
            Console.WriteLine("ClasseBase - Método Public");
        }

        protected void Protected_Membro()
        {
            Console.WriteLine("ClasseBase - Método Protected");
        }

        internal void Internal_Membro()
        {
            Console.WriteLine("ClasseBase - Método Internal");
        }

        protected internal void ProtectedInternal_Membro()
        {
            Console.WriteLine("ClasseBase - Método Protected Internal");
        }

        private void Private_Membro()
        {
            Console.WriteLine("ClasseBase - Método Private");
        }
    }
}
