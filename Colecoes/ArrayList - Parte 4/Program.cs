using System.Collections;

var lista = new ArrayList() { "Maria", 5, true, 4.5, null, DateTime.Now };

//Verificar se um elemento existe na colecao
var res1 = lista.Contains(5);   //true
bool res2 = lista.Contains("Mari"); //false

Console.WriteLine(res1);
Console.WriteLine(res2);
Console.WriteLine(lista.Contains(null)); //true

lista.Sort();   //invalidOperationException


var lista1 = new ArrayList() { "Maria", "Ana", "Zilda", "Carlos", "Diná" };

//ArrayList original
foreach (var item in lista)
{
    Console.WriteLine($"{item}");
}



//ArrayList ordenado
lista.Sort();

foreach (var item in lista1)
{ Console.WriteLine(item); }


//Limpar ArrayList

Console.WriteLine($"Numero de elementos no arrayList antes de limpar {lista1.Count}");

lista1.Clear();

Console.WriteLine($"Numero de elementos no arrayList depois de limpar {lista1.Count}");