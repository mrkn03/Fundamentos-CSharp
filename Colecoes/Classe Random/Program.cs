﻿Random random = new();

int[] numerosSorteados = new int[6];

for (int i = 0; i < 6; i++)
{
    int numeroAleatorio;
    do
    {
        numeroAleatorio = random.Next(1, 61);

    }
    while (numerosSorteados.Contains(numeroAleatorio));

    numerosSorteados[i] = numeroAleatorio;
}

Array.Sort(numerosSorteados);

Console.WriteLine(string.Join(" ", numerosSorteados));