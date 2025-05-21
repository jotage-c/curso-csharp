using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_ex1
{
    abstract class ContaBancaria
    {
        public string? NumeroConta { get; set; }
        public string? Titular{ get; set; }
        public decimal Saldo { get; set; }

        public ContaBancaria(string numero, string titular, decimal saldo)
        {
            NumeroConta = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public abstract decimal CalcularLimiteDisponível();

        public virtual void ExibirResumo()
        {
            Console.WriteLine($"Conta: {NumeroConta} | Titular: {Titular}");
            Console.WriteLine($"Saldo: R$ {Saldo}");
            Console.WriteLine($"Limite disponível: R$ {CalcularLimiteDisponível()}");
            Console.WriteLine(new string('-', 50));
        }
    }
}
