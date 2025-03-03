using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Heranca
{
    class ContaBancaria
    {
        public virtual string? Nome { get; set; }
        public virtual int Numero { get; set; }
        public virtual double Saldo { get; set; } = 0;

        public virtual double Depositar(double valor)
        {
            Saldo += valor;
            return Saldo;
        }   

        public virtual double Sacar(double valor)
        {
            Saldo -= valor;
            return Saldo;
        }

        public virtual void ExibirSaldo()
        {
            Console.WriteLine($"Saldo: {Saldo}");
        }
    }
}
