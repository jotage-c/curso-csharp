using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_ProjetoBancoConsole.Models
{
    public class ContaPessoaJuridica : ContaBancaria
    {
        public decimal LimiteEmpresarial { get; set; } = 10000;
        public decimal TaxaManutencaoMensal { get; set; } = 50;

        public ContaPessoaJuridica(string numero, string titular, decimal saldo)
            : base(numero, titular, saldo) { }

        public override decimal CalcularLimiteDisponivel()
        {
            return (Saldo + LimiteEmpresarial) - TaxaManutencaoMensal;
        }
        public override void Sacar(decimal valor)
        {
            if (valor <= Saldo + LimiteEmpresarial)
            {
                Saldo -= valor;
            } else
            {
                Console.WriteLine($"{Saldo} limite empresarial insuficiemte.");
            }
        }
    }
}
