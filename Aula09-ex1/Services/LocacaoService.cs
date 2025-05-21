using Aula09_ex1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_ex1.Services
{
    public class LocacaoService
    {
        public void AlugarVeiculo(Cliente cliente, ILocavel veiculo)
        {
            if (veiculo.EstaDisponivel)
            {
                Console.WriteLine($"'{veiculo.Modelo}' já está alugado.");
                return;
            }

            veiculo.Alugar();
            Console.WriteLine($"'{veiculo.Modelo}' alugado para {cliente.Nome}.");
        }

        public void DevolverVeiculo(Cliente cliente, ILocavel veiculo)
        {
            if (veiculo.EstaDisponivel)
            {
                Console.WriteLine($"{veiculo.Modelo} já está disponível.");
                return;
            }
            veiculo.Devolver();
            Console.WriteLine($"'{veiculo.Modelo}' devolvido por {cliente.Nome}.");
        }
    }
}
