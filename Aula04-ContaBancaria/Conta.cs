using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_ContaBancaria
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public Conta(int numero, string titular, decimal saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Titular: {Titular} | Saldo: {Saldo}");
        }

        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Você não tem esse dinheiro todo!");
            }
            else
            {
                Saldo -= valor;
            }
        }
        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Transferir(decimal valor, Conta destino)
        {
            Saldo -= valor;
            destino.Saldo += valor;
        }
    }
}
