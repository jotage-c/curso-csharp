using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_ex1
{
    class ContaPessoaJuridica : ContaBancaria
    {
        public decimal LimiteEmpresarial { get; set; } = 5000;
        public decimal TaxaManutencao { get; set; } = 50;

        public ContaPessoaJuridica(string numero, string titular, decimal saldo)
            : base(numero, titular, saldo) { }

        public override decimal CalcularLimiteDisponível()
        {
            return (Saldo + LimiteEmpresarial) - TaxaManutencao;
        }
    }
}
