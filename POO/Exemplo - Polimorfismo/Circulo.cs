﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo___Polimorfismo
{
    class Circulo : Figura
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um círculo");
        }
    }
}
