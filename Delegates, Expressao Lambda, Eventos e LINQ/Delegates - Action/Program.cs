Console.WriteLine("Informe um numero inteiro:");
int numero = Convert.ToInt32(Console.ReadLine());

Action<int> dobra = (x => Console.WriteLine(x * 2));

dobra(numero);
