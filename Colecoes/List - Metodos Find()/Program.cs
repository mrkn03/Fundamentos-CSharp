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

Console.WriteLine($"Expressao lambda -> {fruta2}");