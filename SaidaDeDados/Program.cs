Console.WriteLine("##Saida de dados: Formatacao");
Console.WriteLine();

int idade = 25;
string nome = "Maria";

Console.WriteLine(nome);
Console.WriteLine(idade);

//Escreve na mesma linha ''Maria tem 25 anos'
Console.WriteLine(nome);
Console.WriteLine(" tem ");
Console.WriteLine(idade);
Console.WriteLine(" anos");
Console.WriteLine("--------------------");

//Usando concatenacao
Console.WriteLine(nome + " tem " + idade + " anos");
Console.Write(nome + " tem " + idade + " anos");
Console.WriteLine("\n--------------------");

//Usando interpolacao
Console.WriteLine($"{nome} tem {idade} anos");
Console.WriteLine("--------------------");

//Usando placeholders
Console.WriteLine("{0} tem {1} anos", nome, idade);