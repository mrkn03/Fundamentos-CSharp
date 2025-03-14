﻿using Colecao_Stack___Exemplo;

Console.WriteLine("\n### Stack - Undo ###");

EditorTexto editor = new EditorTexto();
Console.WriteLine("\nDigitando...");

editor.DigitarChar('S');
editor.DigitarChar('t');
editor.DigitarChar('a');
editor.DigitarChar('c');
editor.DigitarChar('q');

Console.WriteLine("\nFazendo o Undo...");
editor.Undo();
editor.Undo();

Console.WriteLine("\nRedigitando...");

editor.DigitarChar('c');
editor.DigitarChar('k');
editor.DigitarChar('!');