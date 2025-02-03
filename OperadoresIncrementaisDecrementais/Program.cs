Console.WriteLine("## Operadores de Incremento e Decremento ##\n");

int x = 1;
x++;
Console.WriteLine(x);
x--;
Console.WriteLine(x);


//pós incremento
int y = 0;
int resultado = y++ + 10;
Console.WriteLine($"pós incremento -> {resultado}");
Console.WriteLine($"Valor de y = {y}");

//pré incremento
int z = 0;
int resultado2 = ++z + 10;
Console.WriteLine($"pré incremento -> {resultado2}");
Console.WriteLine($"Valor de y = {z}");