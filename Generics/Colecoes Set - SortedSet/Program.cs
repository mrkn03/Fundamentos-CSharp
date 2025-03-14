var numeros = new SortedSet<int>() { 1, 2, 3, 4, 5 };
ExibirColecao(numeros);

var frutas = new SortedSet<string>() { "maçã", "banana", "laranja" };
ExibirColecao(frutas);

var pares = new SortedSet<int>();
for (int i  = 6; i  > 0 ; i --)
{
    pares.Add(i * 2);
}
ExibirColecao(pares);

var lista1 = new List<int>() { 1, 2, 3, 4, 5 };
var conunto = new SortedSet<int>(lista1);
ExibirColecao(conunto);

var frutas1 = new List<string> { "uva", "banana", "pera", "manga" };
SortedSet<string> minhasFrutas = new SortedSet<string>(frutas);
ExibirColecao(minhasFrutas);

var impares = new int[] { 1, 13, 7, 9, 11, 13, 5 };
SortedSet<int> meusNumeros = new SortedSet<int>(impares);
ExibirColecao(meusNumeros);

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    foreach (var item in colecao)
    {
        Console.WriteLine(item);
    }
}