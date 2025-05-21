using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_ex1
{
    class ContaPessoaFisica : ContaBancaria
    {
        public decimal ChequeEspecial { get; set; } = 500;

        public ContaPessoaFisica(string numero, string titular, decimal saldo) : base(numero, titular, saldo){}

        public override decimal CalcularLimiteDisponível()
        {
            return Saldo += ChequeEspecial;
        }
    }
}
