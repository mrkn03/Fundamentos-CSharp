// Instanciando a classe Stack
Stack<int> numeros = new Stack<int>();
numeros.Push(1);

int[] array1 = new int[] { 2, 3, 4, 5 };
Stack<int> pilha1 = new Stack<int>(array1);

var impares = new Stack<int>(3);
impares.Push(1);


//Métodos da classe Stack
Stack<int> numeros1 = new Stack<int>();
numeros1.Push(10);
numeros1.Push(20);
numeros1.Push(30);
numeros1.Push(10);

Console.WriteLine($"-A pilha original contém {numeros1.Count} itens");

ExibirPilha(numeros1);

//retorna sem remover
Console.WriteLine($"\n-Item obtido da pilha (Peek)  : {numeros1.Peek()}");

//remove e retorna
Console.WriteLine($"\n-Item Removido da pilha (Pop) : {numeros1.Pop()}");

Console.WriteLine($"\n-A pilha agora contém {numeros1.Count} itens");

if (numeros1.Contains(20))
    Console.WriteLine("\n-Item 20 esta na pilha");
else
    Console.WriteLine("\n-Item 20 não esta na pilha");

Console.WriteLine("\n-Copia a pilha usando ToArray");
var copia = new Stack<int>(numeros1.ToArray());
ExibirPilha(copia);

Console.WriteLine("\n-Removendo todos os itens da pilha\n");
numeros1.Clear();
Console.WriteLine($"{numeros1.Count} itens na pilha");

ExibirPilha(numeros1);

Console.ReadKey();

static void ExibirPilha<T>(IEnumerable<T> numeros)
{
    Console.WriteLine();
    foreach (var item in numeros)
    {
        Console.WriteLine(item);
    }
}