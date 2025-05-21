using Aula08_ProjetoBancoConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_ProjetoBancoConsole.Services
{
    public class OperacoesBancarias
    {
        //static: não pode ser instanciada, geralmente usada pra métodos utilitários
        public static void RealizarDeposito(ContaBancaria conta)
        {
            Console.Write("Valor do depósito: R$ ");
            if(decimal.TryParse(Console.ReadLine(), out decimal valor))
            {
                conta.Depositar(valor);
            } else
            {
                Console.WriteLine("Valor inválido.");
            }
        }

        public static void RealizarSaque(ContaBancaria conta)
        {
            Console.WriteLine("Valor do saque: R$ ");
            if (decimal.TryParse(Console.ReadLine(), out decimal valor))
            {
                conta.Sacar(valor);
            } else
            {
                Console.WriteLine("Valor inválido.");
            }
        }

        public static void ExibirExtrato(ContaBancaria conta)
        {
            conta.ExibirResumo();
        }
    }
}
