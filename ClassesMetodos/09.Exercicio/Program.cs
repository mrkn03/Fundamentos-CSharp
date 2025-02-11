using _09.Exercicio;

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Potencia;
    private int ano;

    public int Ano
    {
        get { return ano; }
        set
        {
            if (value < 2000)
                ano = 2000;
            else if (value > 2022)
                ano = 2022;
            else
                ano = value;
        }
    }

    //campo
    public int Cor;
    //construtor
    public Carro(string? Modelo, string? Montadora, string? Marca,
    int Ano, int Potencia, int cor)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
        Cor = cor;
    }
    //método
    public void ExibirInfo(string? Modelo, string? Montadora, string? Marca,
    int Potencia, int Cor = 1, int Ano = 2022)
    {
        Console.WriteLine(Modelo);
        Console.WriteLine(Montadora);
        Console.WriteLine(Marca);
        Console.WriteLine(Potencia);
        Console.WriteLine(Ano);
        Console.WriteLine((Cores)Cor);
    }
}