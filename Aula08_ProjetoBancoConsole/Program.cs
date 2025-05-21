using Aula08_ProjetoBancoConsole.Models;
using Aula08_ProjetoBancoConsole.Utils;

namespace Aula08_ProjetoBancoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta1 = new ContaPessoaFisica("1111", "Maria da Silva", 1000);
            ContaBancaria conta2 = new ContaPessoaFisica("2222", "Empresa XYZ", 15000);
            Console.WriteLine("Qual cnota deseja acessar?");
            Console.WriteLine("1 - Pessoa Física");
            Console.WriteLine("2 - Pessoa Jurídica");
            Console.WriteLine("Opção: ");
            var escolha = Console.ReadLine();

            if (escolha == "1")
            {
                Menu.Exibir(conta1);
            }
            else if (escolha == "2")
            {
                Menu.Exibir(conta2);
            } else
            {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}
