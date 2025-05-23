using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_ex.Domain.Entities
{
    public class Consumo
    {
        public string Item { get; set; }
        public decimal Valor { get; set; }

        public Consumo(string item, decimal valor)
        {
            if (string.IsNullOrWhiteSpace(item))
            {
                throw new Exceptions.DomainException("Item não pode ser vazio!");
            }
            if (valor <= 0)
            {
                throw new Exceptions.DomainException("Valor deve ser maior que zero");
            }

            Item = item;
            Valor = valor;
        }
    }
}
