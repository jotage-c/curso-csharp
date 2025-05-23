using Aula11_ex.Domain.Entities;
using Aula11_ex.Domain.Exceptions;
using Aula11_ex.Application.Services;

namespace Aula11_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var amigos = new List<Amigo>();
            var servico = new DivisãoService();

            Console.WriteLine("=== Sistema de Divisão de Conta de Restaurante ===");

            try
            {
                Console.Write("Quantos amigos participaram? ");
                int qtd = int.Parse(Console.ReadLine()!);

                for (int i = 0; i < qtd; i++)
                {
                    Console.Write($"\nNome do {i + 1}º amigo: ");

                    var nome = Console.ReadLine();
                    var amigo = new Amigo(nome!);

                    Console.Write($"Quantos itens {nome} consumiu? ");
                    int itens = int.Parse(Console.ReadLine()!);

                    for (int j = 0; j < itens; j++)
                    {
                        Console.Write($"Item {j + 1} (comida/bebida): ");
                        var item = Console.ReadLine();

                        Console.Write($"Valor do item {j + 1}: R$ ");
                        decimal valor = decimal.Parse(Console.ReadLine()!);

                        amigo.Consumos.Add(new Consumo(item!, valor));
                    }
                    amigos.Add(amigo);
                }
                servico.ExibirResumo(amigos);
            }
            catch (DomainException ex)
            {
                Console.WriteLine($"Erro de domínio: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro de formato: Insira números válidos!");
            } 
            catch(Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
            
            Console.WriteLine("\nPressione qualquer tecla para sair...");
            Console.ReadKey();

        }
    }
}
