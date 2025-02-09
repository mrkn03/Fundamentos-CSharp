Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110, 4);
Console.WriteLine("\nUsando parâmetro out => Aumenta potencia e velocidade ");
double novaPotencia = chevrolet.AumentarPotenciaVelocidade(chevrolet.potencia, out double velocidade);
Console.WriteLine("-Nova Potencia : " + novaPotencia);
Console.WriteLine("-Nova Velocidade Máxima : " + velocidade);

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

    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }
}