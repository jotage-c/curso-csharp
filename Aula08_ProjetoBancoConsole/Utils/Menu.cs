using Aula08_ProjetoBancoConsole.Models;
using Aula08_ProjetoBancoConsole.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_ProjetoBancoConsole.Utils
{
    public class Menu
    {
        public static void Exibir(ContaBancaria conta)
        {
            int opcao = 0;

            do
            {
                Console.WriteLine("\n === MENU BANCÁRIO ===");
                Console.WriteLine(" 1 - Ver saldo");
                Console.WriteLine(" 2 - Depositar");
                Console.WriteLine(" 3 - Sacar");
                Console.WriteLine(" 0 - Sair");
                Console.Write("Opção: ");

                //tryparse: tenta fazer parse de uma string para uma variável de tipo x
                int.TryParse(Console.ReadLine(), out
                opcao);
                switch (opcao)
                {
                    case 1:
                        OperacoesBancarias.ExibirExtrato(conta);
                        break;
                    case 2:
                        OperacoesBancarias.RealizarDeposito(conta);
                        break;
                    case 3:
                        OperacoesBancarias.RealizarSaque(conta);
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
