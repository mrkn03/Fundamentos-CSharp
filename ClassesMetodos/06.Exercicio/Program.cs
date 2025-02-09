Console.WriteLine("\nUsando argumentos nomeados e parâmetros opcionais \n");

Console.WriteLine("Sem informar o parâmetro opcional Ano");

Carro ford = new Carro();

ford.ExibirInfo(Modelo: ford.modelo, Montadora: ford.montadora,
Marca: ford.marca, Potencia: ford.potencia);

Console.WriteLine("\nInformando o parâmetro opcional Ano");

ford.ExibirInfo(Modelo: ford.modelo, Montadora: ford.montadora,
Marca: ford.marca, Potencia: ford.potencia, Ano: ford.ano);


Console.WriteLine("Chamando o método estático ObterValorIPVA : ");
Carro.ObterValorIPVA();
Console.WriteLine("Valor do campo ValorIpva : " + Carro.ValorIpva + "%");

public class Carro
{
    public string? modelo;
    public string? montadora;
    public string? marca;
    public int ano;
    public int cavalos;
    public int potencia;
    public static double ValorIpva;

    public Carro()
    { }

    public Carro(string? modelo, string? montadora)
    {
        this.modelo = modelo;
        this.montadora = montadora;
    }

    public Carro(string modelo, string montadora, string marca, int ano, int potencia)
    {
        this.modelo = modelo;
        this.montadora = montadora;
        this.marca = marca;
        this.ano = ano;
        this.potencia = potencia;
    }

    public Carro(string? modelo, string? montadora, string? marca, int ano, int cavalos, int potencia) : this(modelo, montadora)
    {
        this.marca = marca;
        this.ano = ano;
        this.cavalos = cavalos;
        this.potencia = potencia;
    }

    public void Acelerar(string? marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}");
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }

    public int AumentarPotencia(int potencia)
    {
        return potencia += 3;
    }

    public int AumentarPotencia(ref int potencia)
    {
        potencia += 5;
        return potencia;
    }

    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }

    public void ExibirInfo(string? Modelo, string? Montadora, string? Marca, int Potencia, int Ano = 2022)
    {
        Console.WriteLine(Modelo);
        Console.WriteLine(Montadora);
        Console.WriteLine(Marca);
        Console.WriteLine(Potencia);
        Console.WriteLine(Ano);
    }

    public static void ObterValorIPVA()
    {
        ValorIpva = 4;
    }
}