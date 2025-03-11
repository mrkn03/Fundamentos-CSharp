//criacao da colecao hashset com itens
var numeros = new HashSet<int>() { 1, 2, 3, 4, 5 };

var frutas = new HashSet<string>() { "maçã", "banana", "laranja" };

HashSet<int> pares = new HashSet<int>();
for (int i = 0; i < 6; i ++)
{
    pares.Add(i * 2);
}

//usando IEnumerable
var lista1 = new List<int>() { 1, 2, 3, 4, 5 };
var conunto = new HashSet<int>(lista1);

var lista2 = new List<string>() { "maçã", "banana", "laranja" };
var frutas2 = new HashSet<string>(lista2);

var impares = new int[] { 1, 3, 5, 7, 9 };
HashSet<int> impares2 = new HashSet<int>(impares);