string[] alunos = new string[5];
double[] notas = new double[5];

for(int i = 0; i< alunos.Length; i++)
{
    Console.Write($"Digite o nome do {i+1} aluno: ");
    alunos[i] = Console.ReadLine();
    Console.Write($"Digite a nota do {i+1} aluno: ");
    notas[i] = Convert.ToDouble(Console.ReadLine());

}

Console.WriteLine("\nAlunos :");
foreach(string nome in alunos)
{
    Console.WriteLine($"{nome} ");
}

Console.WriteLine("\nNotas :");
var somaNotas = 0.0;
var totalNotas = notas.Count();
foreach(int nota in notas)
{
    somaNotas += nota;
    Console.WriteLine($"{nota}");
}

Console.WriteLine($"Media aritmetica: {somaNotas/totalNotas}");