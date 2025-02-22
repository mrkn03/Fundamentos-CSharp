//Adicionando elementos a lista

var lista = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Ze" };

lista.Add("Marta");

lista.Insert(2, "Bia");

Console.WriteLine(lista.Count + " itens");

//Inserindo um array em uma lista

var lista1 = new List<string>() { "Maria", "Ana", "Pedro"};

string[] array1 = {"Diná", "Rui", "Marta" };

lista1.AddRange(array1);

lista1.InsertRange(1, array1);

//Remover elementos da lista
var lista2 = new List<int>() { 9, 5, 4, 1, 7, 8, 3, 6, 9, 0};

lista2.Remove(7);

lista.RemoveAt(4);

lista.RemoveRange(0, 2);

//Acessar um elemento da listsa usando indice
var lista3 = new List<string>() { "Maria", "Ana", "Pedro" };

var primeiro = lista[0];

var quarto = lista[3];

//Alterar um elemento da lista
var lista4 = new List<string>() { "Maria", "Ana", "Pedro" };

lista[0] = "Zé";
lista[3] = "Silvar";

//Iteracao usando o for
var lista5 = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Ze" };

for(int i = 0; i < lista5.Count; i++)
{
    Console.WriteLine(lista5[i]);
}

//Iteracao usando o foreach
var lista6 = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Ze" };

foreach (var item in lista6)
{
    Console.WriteLine(item);
}

//Verificar se um elemento existe na lista
var lista7 = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Ze" };

var res1 = lista.Contains("Ana");
var res2 = lista.Contains("Zé");

var res3 = lista.Contains("Ze");
var res4 = lista.Contains("Mari");


//Ordenacao e remocao de todos os elementos
var lista8 = new List<string>() { "Maria", "Ana", "Zilda", "Carlos", "Diná" };

lista8.Sort(); //Ordena a lista

lista8.Reverse(); //Inverte a lista

lista8.Clear(); //Remove todos os elementos da lista

