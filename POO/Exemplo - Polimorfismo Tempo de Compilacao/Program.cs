Calcular calc = new Calcular();

Console.WriteLine(calc.Soma(1, 2));
Console.WriteLine(calc.Soma(1, 2, 3));
Console.WriteLine(calc.Soma(1.5, 2.5));



class Calcular
{
    public int Soma(int a, int b)
    {
        return a + b;
    }
    public int Soma(int a, int b, int c)
    {
        return a + b + c;
    }
    public double Soma(double a, double b)
    {
        return a + b;
    }
}