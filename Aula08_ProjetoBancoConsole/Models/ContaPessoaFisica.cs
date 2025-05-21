using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_ProjetoBancoConsole.Models
{
    public class ContaPessoaFisica : ContaBancaria
    {
        public decimal ChequeEspecial { get; set; } = 500;
        //o construtor usa o código de outro construct que precisa dos os valores numero, titular e saldo do construtor
        //para o da classe pai (base), tirando a necessidade
        //de criar outro construtor aqui
        public ContaPessoaFisica(string numero, string titular, decimal saldo)
            : base(numero, titular, saldo) {}

        public override decimal CalcularLimiteDisponivel()
        {
            return Saldo + ChequeEspecial;
        }

        public override void Sacar(decimal valor)
        {
            if (valor <= Saldo + ChequeEspecial)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine($"{Saldo} + cheque especial insuficiente.");
            }
        }
    }
}
