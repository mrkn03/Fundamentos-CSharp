﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores____is_e_as
{
    class Forma
    {
        protected int xpos, ypos;

        public Forma()
        { }

        public Forma(int x, int y)
        {
            xpos = x;
            ypos = y;
        }

        public virtual void Desenhar()
        {
            Console.WriteLine($"Desenhar - Forma na posição : ({xpos},{ypos})");
        }
    }
}
