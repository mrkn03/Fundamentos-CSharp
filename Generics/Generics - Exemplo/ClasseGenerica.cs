using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics___Exemplo
{
    class ClasseGenerica<T>
    {
        protected T[] obj = new T[5];
        protected int Contador = 0;

        public void Adicionar(T item)
        {
            if (Contador < 5)
            {
                obj[Contador] = item;
            }
            Contador++;
        }


        //Indexador para a iteração da instrução foreach
        public T this[int index]
        {
            get { return obj[index]; }
            set { obj[index] = value; }
        }
    }
}
