Console.WriteLine("## Metodos ##\n");

MinhaClasse minhaClasse = new MinhaClasse();

minhaClasse.saudacao();

class MinhaClasse
{
    public void saudacao() {
        Console.WriteLine("Bem Vindo");
        exibirDataAtual();
    }

    public void exibirDataAtual()
    {
        Console.WriteLine(DateTime.Now);
    }
}