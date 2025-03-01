using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    class Time
    {
        //Definir os limites do array
        string[] valor = new string[10];


        public string this[int index]
        {
            get
            {
                if ((index >= 0) && index < valor.Length )
                {
                    return valor[index];
                }
                return "Erro";
            }

            set
            {
                if ((index >= 0) && index < valor.Length)
                {
                    //atribuir o valor
                    valor[index] = value;
                }
            }
        }

    }
}
