Console.WriteLine("## Classes e Métodos ##\n");

Pessoa p1 = new Pessoa();
p1.nome = "João";
p1.idade = 20;
p1.sexo = "M";

Pessoa p2 = new Pessoa();
p2.nome = "Maria";
p2.idade = 30;
p2.sexo = "F";

class Pessoa
{
    public string? nome;
    public int idade;
    public string? sexo;


}