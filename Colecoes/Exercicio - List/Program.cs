using Exercicio___List;

List<Aluno> alunos = new();

alunos.Add(new Aluno("Maria", 8.75));
alunos.Add(new Aluno("Manoel", 6.95));
alunos.Add(new Aluno("Amanda", 7.25));
alunos.Add(new Aluno("Carlos", 6.55));
alunos.Add(new Aluno("Jaime", 8.5));
alunos.Add(new Aluno("Debora", 5.95));
alunos.Add(new Aluno("Alicia", 9.25));
alunos.Add(new Aluno("Sandra", 5.55));
alunos.Add(new Aluno("Marta", 7.85));
alunos.Add(new Aluno("Sueli", 9.15));

Aluno.ExibirAlunos(alunos);
Aluno.MediaAritmetica(alunos);


alunos.Add(new Aluno("Bia", 7.75));
alunos.Add(new Aluno("mario", 8.95));


if (Aluno.ProcuraAluno(alunos, "Amanda"))
{
    Console.WriteLine("Aluno encontrado");
    Aluno.RemoveAluno(alunos, "Amanda");
    Console.WriteLine("Aluno removido");
}
else
{
    Console.WriteLine("Aluno não encontrado");
}

//Lista ordenada
var listaOrdenada = alunos.OrderBy(alunos => alunos.getNome()).ToList();

Aluno.ExibirAlunos(listaOrdenada);