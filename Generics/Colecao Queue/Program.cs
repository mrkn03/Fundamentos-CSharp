﻿Queue<string> diasSemana = new Queue<string>();
//Adicionando elementos na fila
diasSemana.Enqueue("Segunda");
diasSemana.Enqueue("Terça");
diasSemana.Enqueue("Quarta");
diasSemana.Enqueue("Quinta");
diasSemana.Enqueue("Sexta");
diasSemana.Enqueue("Sábado");
diasSemana.Enqueue("Domingo");


int[] array1 = new int[] { 1, 2, 3, 4, 5 };
var numeros = new Queue<int>(array1);

var impares = new Queue<int>(3);
impares.Enqueue(1);


string[] cursos = { "C#", "Phyton", "Java", "SQL", "ASP.NET" };
Queue<string> fila1 = new Queue<string>();

fila1 = new Queue<string>(cursos);
Console.WriteLine("No. de Elementos na fila 1 :  " + fila1.Count());

ExibirFila(fila1);

Console.WriteLine("\n-Método Enqueue - inclui item : .NET MAUI");
fila1.Enqueue(".NET MAUI");
foreach (var item in fila1)
{
    Console.WriteLine(item);
}
Console.WriteLine();

Console.WriteLine("\n-Método Dequeue - remove item do início da fila");
fila1.Dequeue();
foreach (var item in fila1)
{
    Console.WriteLine(item);
}

if (fila1.Contains("C#"))
    Console.WriteLine("C# esta na fila");
else
    Console.WriteLine("C# NÃO esta na fila");

Console.WriteLine("\n-Obtem o primeiro item da fila com Peek");
var elemento = fila1.Peek();
Console.WriteLine(elemento);

Console.WriteLine("\n-Limpa a fila com Clear()");
fila1.Clear();
Console.WriteLine("No. de Elementos na fila 1 :  " + fila1.Count());

Console.ReadKey();

static void ExibirFila<T>(IEnumerable<T> fila1)
{
    Console.WriteLine();
    foreach (var item in fila1)
    {
        Console.WriteLine(item);
    }
}