﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca___Downcasting_e_Upcasting
{
    class Circulo : Forma
    {
        public Circulo()
        { }

        public Circulo(int x, int y) : base(x, y)
        { }

        public override void Desenhar()
        {
            Console.WriteLine($"Desenhar círculo na posição : ({xpos},{ypos})");
        }

        public void PintarCirculo()
        {
            Console.WriteLine("Pintar o Circulo");
        }
    }
}
