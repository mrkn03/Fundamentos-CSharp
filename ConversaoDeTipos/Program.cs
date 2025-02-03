Console.WriteLine("## Conversao de tipos  ##\n");

//Conversao implicita

int varInt = 100;
double varDouble = varInt;

Console.WriteLine(varDouble);

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

//Conversao explicita
double valorDouble = 1234.56;
int valorInteiro = (int)valorDouble;

Console.WriteLine(valorInteiro);

int num1 = 10;
int num2 = 4;

float resultado = num1 / num2;

Console.WriteLine(resultado);