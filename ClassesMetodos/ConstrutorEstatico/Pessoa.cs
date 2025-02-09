public class Pessoa
{
    public static int IdadeMinima;

    public int Idade { get; set; }
    public string Nome { get; set; } = string.Empty;

    public Pessoa()
    {}
    public Pessoa(int idade, string nome)
    {
        Console.WriteLine("\nExecutando o construtor parametrizado");
        Idade = idade;
        Nome = nome;
    }


    static Pessoa()
    {
        Console.WriteLine("\nExecutando o construtor estatico");
        Console.WriteLine("\nInicializando o campo IdadeMinima");
        IdadeMinima = 18;
    }
}
