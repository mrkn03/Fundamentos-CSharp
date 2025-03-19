Console.WriteLine("Informe um numero flutuante: ");
double numero = Convert.ToDouble(Console.ReadLine());


Func<double, double> raizQuadrada = (x => Math.Sqrt(x));

Console.WriteLine($"A raiz quadrada de {numero} é {raizQuadrada(numero)}");