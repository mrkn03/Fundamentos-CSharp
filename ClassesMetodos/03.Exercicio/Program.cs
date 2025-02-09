Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120, 5);


Console.Write("\nAumentando a Potencia (por referência : +5CV) : ");
var novaPotenciaFord = ford.AumentarPotencia(ref ford.potencia);
Console.Write("-> " + novaPotenciaFord);
Console.WriteLine("\nO valor do campo Potencia foi alterado : " + ford.potencia);

public class Carro
{
    public string? modelo;
    public string? montadora;
    public string? marca;
    public int ano;
    public int cavalos;
    public int potencia;

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

}