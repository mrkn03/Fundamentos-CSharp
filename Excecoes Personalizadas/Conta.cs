namespace Excecoes_Personalizadas
{
    class Conta
    {
        public Conta(int numero, string? titular, decimal saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public int Numero { get; set; }
        public string? Titular { get; set; }
        public decimal Saldo { get; set; }

        public decimal Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depositou : {valor}");
            return Saldo;
        }

        public decimal Sacar(decimal valor)
        {
            Console.WriteLine($"Sacou : {valor}");

            if (Saldo < valor)
                throw new SaldoInsuficienteException(valor, Saldo);

            Saldo -= valor;
            return Saldo;
        }
        public override string ToString()
        {
            return $"Conta : {Numero} : {Titular} - Saldo={Saldo}";
        }
    }
}
