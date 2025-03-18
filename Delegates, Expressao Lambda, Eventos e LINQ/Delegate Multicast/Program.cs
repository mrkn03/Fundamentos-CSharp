
MeuDelegate meuDelegate = new MeuDelegate(Metodo1);
meuDelegate += Metodo2;
meuDelegate += Metodo3;

meuDelegate("Olá Mundo");


static void Metodo1(string mensagem)
{
    Console.WriteLine("Metodo 1:" + mensagem);
}

static void Metodo2(string mensagem)
{
    Console.WriteLine("Metodo 2:" + mensagem);
}

static void Metodo3(string mensagem)
{
    Console.WriteLine("Metodo 3:" + mensagem);
}


public delegate void MeuDelegate(string mensagem);