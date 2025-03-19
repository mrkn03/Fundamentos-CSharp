using System.Security;

Console.WriteLine("Informe um numero inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());

Predicate<int> verificaPar =  (x => x % 2 == 0);

if (verificaPar(numero))
    Console.WriteLine($"O numero {numero} é PAR");
else
    Console.WriteLine($"O numero {numero} é IMPAR");
