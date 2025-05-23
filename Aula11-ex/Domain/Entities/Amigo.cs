using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_ex.Domain.Entities
{
    public class Amigo
    {
        public string Nome { get; set; }
        public List<Consumo> Consumos { get; set; } = new();

        public Amigo(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exceptions.DomainException("Nome do amigo não pode ser vazio!");
            }
            Nome = nome;
        }

        public decimal TotalConsumido()
        {
            //itera sobre cada item c de Consumos, pega suas variáveis "valor" e as soma
            return Consumos.Sum(c => c.Valor);
        }
    }
}
