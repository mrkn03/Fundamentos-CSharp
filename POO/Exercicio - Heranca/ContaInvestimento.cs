using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Heranca
{
    class ContaInvestimento : ContaBancaria
    {
        private double Taxa = 0.9;
        private double Imposto = 0.1;

        public override double Depositar(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor inválido");
                return Saldo;
            }

            Saldo += (valor * Taxa);
            return Saldo;
        }

        public override double Sacar(double valor)
        {
            if(Saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente");
                return Saldo;
            }
            
            Saldo -= (valor * Imposto);
            return Saldo;
        }
    }
}