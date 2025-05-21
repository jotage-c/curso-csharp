using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_ProjetoBancoConsole.Models
{
    public abstract class ContaBancaria
    {
        public string NumeroConta { get; set; }
        public string Titular { get; set; }
        //protected: pode ser acessado pela própria classe e derivadas
        public decimal Saldo { get; protected set; }

        public ContaBancaria(string numero, string titular, decimal saldo)
        {
            NumeroConta = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public abstract decimal CalcularLimiteDisponivel();

        public virtual void Sacar(decimal valor)
        {
            //se valor for menor ou igual ao saldo
            if(valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }

        public virtual void Depositar(decimal valor)
        {
            if(valor > 0)
            {
                Saldo += valor;
            }
        }

        public virtual void ExibirResumo()
        {
            Console.WriteLine($"Conta : {NumeroConta} | Titular: {Titular}");
            Console.WriteLine($"Saldo: R$ {Saldo}");
            Console.WriteLine($"Limite disponível: R$ {CalcularLimiteDisponivel()}");
            Console.WriteLine(new string('-', 50));
        }
    }
}
