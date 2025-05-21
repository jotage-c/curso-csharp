using Aula09_ex1.Services;
using Aula09_ex1.Models;

namespace Aula09_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Lucas");
            LocacaoService locadora = new LocacaoService();

            Carro carro = new Carro("Fiat Argo", 4);
            Moto moto = new Moto("Honda CG 160", true);

            Console.WriteLine("--- Alugando Veiculos ---");
            locadora.AlugarVeiculo(cliente, carro);
            locadora.AlugarVeiculo(cliente, moto);

            Console.WriteLine("\n--- Tentando alugar novamente (falha esperada) ---");
            locadora.AlugarVeiculo(cliente, carro);
            
            Console.WriteLine($"\n-- Devolvendo Veículos ---");
            locadora.DevolverVeiculo(cliente, carro);
            locadora.DevolverVeiculo (cliente, moto);

            Console.WriteLine($"\n--- Tentando devolver novamente (falha esperada) ---");
            locadora.DevolverVeiculo(cliente, carro);
        }
    }
}
