using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Heranca
{
    class ContaCorrente : ContaBancaria
    {
        public override double Depositar(double valor)
        {
            Saldo += valor;
            return Saldo;
        }

        public override double Sacar(double valor)
        {
            Saldo -= valor;
            return Saldo;
        }

        public override void ExibirSaldo()
        {
            Console.WriteLine($"Número da Conta - {Numero}\tCliente - {Nome}");
            Console.WriteLine($"Saldo da conta corrente: {Saldo}");
        }
    }
}
