using System.Collections;

//Comportamento de List<T> comparado com ArrayList

//No ArrayList
ArrayList lista = new ArrayList();
lista.Add(3);
lista.Add(4);

var elemento = lista[0];

int numero = (int)lista[1];

//Na List
List<int> lista1 = new List<int>();
lista1.Add(1);

var item = lista[0];