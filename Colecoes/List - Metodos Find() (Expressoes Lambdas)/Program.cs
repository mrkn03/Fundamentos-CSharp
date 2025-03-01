List<string> frutas = new() { "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango" };


//Usando predicado como funcao
var fruta1 = frutas.Find(Procura);

Console.WriteLine($"Predicado -> {fruta1}");

static bool Procura(string item)
{
    return item.Contains('n');
}


//Usando predicado como expressao lambda
var fruta2 = frutas.Find(i => i.Contains('n'));
Console.WriteLine($"\nFind -> {fruta2}");

var fruta3 = frutas.FindLast(i => i.Contains('n'));
Console.WriteLine($"\nFindLast -> {fruta3}");

var fruta4 = frutas.FindIndex(i => i.Contains('n'));
Console.WriteLine($"\nFindIndex -> {fruta4}");

var fruta5 = frutas.FindLastIndex(i => i.Contains('n'));
Console.WriteLine($"\nFindLastIndex -> {fruta5}");

var fruta6 = frutas.FindAll(i => i.Contains('n'));
Console.WriteLine($"\nFindAll -> {string.Join(", ", fruta6)}");