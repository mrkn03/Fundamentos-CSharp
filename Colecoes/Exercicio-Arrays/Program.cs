string?[] alunos = new string[5];
double[] notas = new double[5];

for (int i = 0; i < alunos.Length; i++)
{
    Console.Write($"Digite o nome do {i + 1} aluno: ");
    string? aluno = Console.ReadLine();
    alunos[i] = aluno;


}

for (int i = 0; i < notas.Length; i++)
{
    Console.Write($"Digite a nota do {i + 1} aluno: ");
    double nota = Convert.ToDouble(Console.ReadLine());
    notas[i] = nota;
}

Console.WriteLine("\nAlunos :");
foreach (string? nome in alunos)
{
    Console.WriteLine($"{nome} ");
}

Console.WriteLine("\nNotas :");
var somaNotas = 0.0;
var totalNotas = notas.Count();
foreach (int nota in notas)
{
    somaNotas += nota;
    Console.WriteLine($"{nota}");
}

Console.WriteLine($"Media aritmetica: {somaNotas / totalNotas}");