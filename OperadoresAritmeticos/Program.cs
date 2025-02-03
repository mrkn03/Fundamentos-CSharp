Console.WriteLine("## Operadores Aritimeticos ##\n");

Console.Write("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"soma de x + y = {x + y}");
Console.WriteLine($"subtraçao de x - y = {x - y}");
Console.WriteLine($"multiplicacao de x * y = {x * y}");
double divisao = (double)x / y;
Console.WriteLine($"divisao de x / y = {divisao}");
Console.WriteLine($"modulo de x % y = {x % y}");

//Usando classe Math
Console.WriteLine($"Raiz quadrada de x = {Math.Sqrt(x)}");
Console.WriteLine($"potencia de x elevado a y = {Math.Pow(x, y)}");
Console.WriteLine($"valor maximo entre x e y = {Math.Max(x, y)}");
Console.WriteLine($"valor minimo entre x e y = {Math.Min(x, y)}");
Console.WriteLine($"coseno de x = {Math.Cos(x)}");
Console.WriteLine($"seno de x = {Math.Sin(x)}");
Console.WriteLine($"exponencial de x = {Math.Exp(x)}");