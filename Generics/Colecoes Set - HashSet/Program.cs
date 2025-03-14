
var timesSP = new HashSet<string> { "Santos", "Palmeiras", "São Paulo" };
var timesRJ = new HashSet<string>() { "Vasco", "Flamengo", "Fluminense" };
var timesBA = new HashSet<string>() { "Bahia", "Vitória", "Juazeiro" };
var timesMundiais = new HashSet<string>() { "Santos", "Palmeiras", "São Paulo", "Flamengo" };

// Verifica se um item está contido no conjunto
if (!timesSP.Contains("Corinthians"))
{
    // Adiciona um item ao conjunto
    timesSP.Add("Corinthians");
}
// Remove um item no conjunto e armazenar o resultado
var resultado = timesBA.Remove("Juazeiro");


// Verifica se um conjunto é subconjunto de outro
if (timesSP.IsSupersetOf(timesMundiais))
{
    Console.WriteLine("SP é um superconjunto de times mundiais");
}
else
{
    Console.WriteLine("SP não é um superconjunto de times mundiais");
}

if (timesMundiais.IsSupersetOf(timesSP))
{
    Console.WriteLine("Times mundiais é um superconjunto de SP");
}
else
{
    Console.WriteLine("Times mundiais não é um superconjunto de SP");
}

// Verifica se um conjunto é subconjunto próprio de outro
if (timesRJ.Overlaps(timesMundiais))
{
    Console.WriteLine("Pelo menos um time do RJ tem título Mundial");
}

// Verifica se dois conjuntos são iguais
if (!timesSP.SetEquals(timesRJ))
{
    Console.WriteLine("\ntimesSP e timesRJ não contém os mesmos elementos");
}

Console.WriteLine("\n-Juntando os HashSet<T> : SP , RJ e BA ");
timesSP.UnionWith(timesRJ);
timesSP.UnionWith(timesBA);
ExibirColecao(timesSP);

Console.WriteLine("\nJuntando os Times de SP, RJ e BA ordenados");
var todosTimes = new SortedSet<string>(timesSP);
ExibirColecao(todosTimes);

Console.WriteLine("\nInterseção de dois HashSet<T> : timesSP e timesMundiais");
timesSP.IntersectWith(timesMundiais);
ExibirColecao(timesSP);

Console.WriteLine("\nDiferenca de dois HashSet<T> : timesMundiais e timesSP");
timesMundiais.ExceptWith(timesSP);
ExibirColecao(timesMundiais);

Console.WriteLine("\nDiferenca de dois HashSet<T> : timesMundiais e timesSP com SymmetricExceptWith ");
timesMundiais.SymmetricExceptWith(timesSP);
ExibirColecao(timesMundiais);

Console.WriteLine("\nRemove todos os elementos de timesMundiais");
timesMundiais.Clear();
ExibirColecao(timesMundiais);
Console.Write("Fim do processamento...");

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    foreach (var time in colecao)
    {
        Console.WriteLine($"{time} ");
    }
}