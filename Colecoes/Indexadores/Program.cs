﻿using Indexadores;

Time time = new Time();

//Atribuir valores usando o set
time[1] = "Palmeiras";
time[3] = "Samtos";
time[5] = "Corinthians";
time[7] = "Vasco";

time[-1] = "Flamengo";
time[100] = "Bahia";


//Obter valores usando o get
string valor1 = time[1];
string valor2 = time[3];
string valor3 = time[5];
string valor4 = time[7];
string valor5 = time[-1];
string valor6 = time[100];

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);