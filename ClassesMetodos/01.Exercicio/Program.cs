
Carro chevrolet = new Carro("Sedan", "Chevrolet", "Onix", 2016, 110);

chevrolet.Acelerar(chevrolet.marca);
Console.WriteLine($"{chevrolet.modelo} {chevrolet.montadora} {chevrolet.marca}" +

$" {chevrolet.ano} {chevrolet.potencia} CV");

Carro ford = new Carro("SUV", "Ford", "EcoSport", 2018, 120);

ford.Acelerar(ford.marca);

Console.WriteLine($"{ford.modelo} {ford.montadora} {ford.marca}" +
$" {ford.ano} {ford.potencia} CV");

public class Carro
{
    public string? modelo;
    public string? montadora;
    public string? marca;
    public int ano;
    public double potencia;

    public Carro()
    {}

    public Carro(string modelo, string montadora, string marca, int ano, double potencia)
    {
        this.modelo = modelo;
        this.montadora = montadora;
        this.marca = marca;
        this.ano = ano;
        this.potencia = potencia;
    }

    public void Acelerar(string marca)
    {
        Console.WriteLine($"Acelerando o meu {marca}");
    }

    
}