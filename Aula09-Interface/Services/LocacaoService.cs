using Aula09_Interface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Interface.Services
{
    public class LocacaoService
    {
        public void LocarItem(Cliente cliente, ILocavel item)
        {
            if (!item.EstaDisponivel)
            {
                Console.WriteLine($"{item.Titulo} não está disponível");
                return;
            }
            item.Alugar();
            Console.WriteLine($"{item.Titulo} está locado para o cliente {cliente.Nome}");
        }
        public void DevolverItem(Cliente cliente, ILocavel item)
        {
            if (item.EstaDisponivel)
            {
                Console.WriteLine($"{item.Titulo} está disponível para locação");
                return;
            }
            item.Devolver();
            Console.WriteLine($"{item.Titulo} devolvido por {cliente.Nome}");
        }
    }
}
