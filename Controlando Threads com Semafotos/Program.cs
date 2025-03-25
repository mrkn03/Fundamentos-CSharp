class Program
{
    public static Semaphore threadPool = new Semaphore(3, 5);
    static void Main(string[] args)
    {
        for(int i =0 ; i < 10; i++)
        {
            Thread threadObject = new Thread(new ThreadStart(ProcessarOperacao));

            threadObject.Name = $"Thread {i}";
            threadObject.Start();

        }
    }

    private static void ProcessarOperacao()
    {
        Console.WriteLine($"Thread {Thread.CurrentThread.Name}" + 
            $"Entrou na sessao critica...");

        Thread.Sleep(6000);

        Console.WriteLine($"Thread {Thread.CurrentThread.Name}" +
            $"Foi liberada...");
    }
}