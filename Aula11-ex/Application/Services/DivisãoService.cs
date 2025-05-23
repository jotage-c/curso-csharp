using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula11_ex.Domain.Entities;

namespace Aula11_ex.Application.Services
{
    public class DivisãoService
    {
        public void ExibirResumo(List<Amigo> amigos)
        {
            Console.WriteLine("\n ====== RESUMO ======\n");
            decimal totalGeral = 0;

            foreach (var amigo in amigos)
            {
                decimal total = amigo.TotalConsumido();
                totalGeral += total;

                Console.WriteLine($"{amigo.Nome} consumiu R$ {total:F2}");
            }
            Console.WriteLine($"\nTotal geral da conta: R$ {totalGeral:F2}");

            decimal media = totalGeral / amigos.Count();
            Console.WriteLine($"\nCada um deve pagar aproximadamente: R$ {media:F2}");
        }
    }
}
