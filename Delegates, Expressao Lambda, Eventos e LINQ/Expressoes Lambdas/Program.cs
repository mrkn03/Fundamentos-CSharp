﻿List<string> nomes = new List<string>();
nomes.Add("Maria");
nomes.Add("Miriam");
nomes.Add("Paulo");
nomes.Add("Carlos");

//string resultado = nomes.Find(verificaNomeNaLista);

string resultado = nomes.Find(nome => nome.Equals("Paulo"));

Console.WriteLine(resultado);
