﻿using Exemplo___Polimorfismo;

var figuras = new List<Figura>
{
    new Triangulo(),
    new Circulo()
};

foreach(var figura in figuras)
{
    figura.Desenhar();
}