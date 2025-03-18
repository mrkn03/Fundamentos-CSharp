using Excecoes_Personalizadas;

Conta conta1 = new Conta(100, "Maria", 100m);

try
{
    Console.WriteLine(conta1.ToString());
    conta1.Depositar(100);
    Console.WriteLine($"Saldo : {conta1.Saldo}");
    conta1.Sacar(300);
    Console.WriteLine($"Saldo : {conta1.Saldo}");
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.HelpLink);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
