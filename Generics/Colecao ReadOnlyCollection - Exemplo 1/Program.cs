﻿using Colecao_ReadOnlyCollection___Exemplo_1;
using System.Collections.ObjectModel;

var exoPlanetas = new ReadOnlyCollection<ExoPlaneta>(ExoPlaneta.GetExoPlanetas());

//alterações não permitidas
//exoPlanetas[0]= "Kepler-442b";
//exoPlanetas[0] = new ExoPlaneta() { Nome = "Kepler-442b" };

exoPlanetas[0].Nome = "Kepler-442b";

Console.WriteLine("\nLista de exoplanetas : \n");
foreach (var item in exoPlanetas)
    Console.WriteLine(item.Nome);