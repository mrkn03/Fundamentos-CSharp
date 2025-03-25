class Program
{
    static async Task Main(string[] args)
    {
        //var meses = new List<string>() { "Janeiro", "Fevereiro", "Março", "Abril" };
        await foreach(var mes in GeraMeses())
        {
            Console.WriteLine(mes);
        }
    }

    static private async IAsyncEnumerable<string> GeraMeses()
    {
        yield return "Janeiro";
        yield return "Fevereiro";
        await Task.Delay(1000);
        yield return "Março";
        yield return "Abril";
    }
}
