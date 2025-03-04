using Classe_Abstrata;

Quadrado q = new Quadrado();
Console.WriteLine(q.Descricao());

Console.WriteLine("\nInforme a cor da figura");
q.Cor = Console.ReadLine();

Console.WriteLine("\nInforme o valor do lado do quadrado");
q.Lado = Convert.ToInt32(Console.ReadLine());

q.CalcularArea();
q.CalcularPerimetro();

Console.WriteLine("\nA área do quadrado é: " + q.Area);
Console.WriteLine("\nO perímetro do quadrado é: " + q.Perimetro);

Console.WriteLine($"\nO quadrado tem a cor: {q.Cor}");