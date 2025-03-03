using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Heranca
{
    class ContaPoupanca : ContaBancaria
    {
        private double Juros { get; set; }

        public override double Depositar(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor inválido");
                return Saldo;
            }

            Saldo += valor + (valor * Juros);
            return Saldo;
        }

        public override double Sacar(double valor)
        {
            if (Saldo < valor) {
                Console.WriteLine("Saldo insuficiente");
                return Saldo;
            }

            Saldo -= valor;
            return Saldo;
        }

        public override void ExibirSaldo()
        {
            Console.WriteLine($"Número da Conta - {Numero}\tCliente - {Nome}");
            Console.WriteLine($"Saldo da conta poupança: {Saldo}");
        }
    }
}
