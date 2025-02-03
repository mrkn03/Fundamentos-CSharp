Console.WriteLine("## Inferencia de Tipos ##\n");

var idade = 25;
var nome = "Maria";
var salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e recebe R${salario}");

////Limitacoes var
//var salario = null; //Erro
//var titulo; //Erro
//var salario, imposto, total; //Erro

//Nao posso mudar o tipo apos inicializar
var num = 10;
num += 20;
//num = "teste"; //Erro

