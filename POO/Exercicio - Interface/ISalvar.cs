﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Interface
{
    public interface ISalvar
    {
        void Salvar();
        void Compactar()
        {
            Console.WriteLine("Compactando arquivos");
        }
    }
}
