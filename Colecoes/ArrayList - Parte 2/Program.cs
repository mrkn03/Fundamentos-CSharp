using System.Collections;

//Adicionar Elementos
var lista = new ArrayList() { "Maria", 5, true, " ", null };

lista.Add(3.5);
lista.Insert(2, "Paulo");

//Adicionar coleção de Elementos
var lista1 = new ArrayList() { "Maria", 5, true };

int[] array1 = { 1, 2, 3 };

lista1.AddRange(array1);
lista1.InsertRange(2, array1);