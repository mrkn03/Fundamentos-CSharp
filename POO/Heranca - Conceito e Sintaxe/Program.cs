using System.Security;
using Heranca___Conceito_e_Sintaxe;

Funcionario funci = new();
funci.Nome = "Jose";
funci.Email = "Jose@email.com";
funci.Empresa = "Google Inc.";
funci.Salario = 10000;

Console.WriteLine("Funcionario");
Console.WriteLine(funci.Empresa);
Console.WriteLine(funci.Salario);
funci.Identificar();


Aluno aluno = new();
aluno.Nome = "Joao";
aluno.Email = "Joao@email.com";
aluno.Curso = "Engenharia";
aluno.Nota = 9.5;
aluno.Identificar();
