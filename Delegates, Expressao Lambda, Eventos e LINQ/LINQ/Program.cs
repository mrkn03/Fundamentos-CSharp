
//Usando sintaxe de consulta
List<string> nomes = new List<string>() { "Ana", "Maria", "Pedro", "Lair", "Hugo" };

var resultado = from nome in nomes
                where nome.Contains('o')
                select nome;

ExibirResultado(resultado);


//Usando sintaxe de métodos
var resultado1 = nomes.Where(nome => nome.Contains('a'));
ExibirResultado(resultado1);


static void ExibirResultado(IEnumerable<string> resultado)
{
    Console.WriteLine();
    foreach (var item in resultado)
    {

        Console.WriteLine(item);
    }
}