﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Interface
{
    abstract class ArquivoBase
    {
        public virtual void Nome()
        {
            Console.WriteLine("Definir o nome do arquivo");
        }
    }
}
