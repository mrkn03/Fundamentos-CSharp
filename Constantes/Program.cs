using System.Data;
using System.Runtime.Serialization;

Console.WriteLine("## Constantes ##\n");

const int ANO = 12;

const int MES = 30, SEMANA = 7, QUINZENA = 15;

const int MES_ANO = 12;
const int DIAS_ANO = 365;

const float DIAS_POR_MES = DIAS_ANO / MES_ANO;
Console.WriteLine(DIAS_POR_MES);

//Calculo da area e perimetro do circulo
double raio, perimetro, area;

const double PI = 3.14159;

Console.Write("Informe o raio do circulo: ");
raio = double.Parse(Console.ReadLine());

perimetro = 2 * PI * raio;
area = PI * Math.Pow(raio, 2);

Console.WriteLine($"Perimetro: {perimetro}");
Console.WriteLine($"Area: {area}");