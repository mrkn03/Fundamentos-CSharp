﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo___Polimorfismo
{
    class Triangulo : Figura
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um triangulo.");
            base.Desenhar();
        }
    }
}
