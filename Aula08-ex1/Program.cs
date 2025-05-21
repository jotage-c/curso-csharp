namespace Aula08_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Sistema Bancário com Herança e Polimorfismo
            🎯 Objetivo:
            Usar herança para criar um modelo base ContaBancaria.
            Usar polimorfismo com o método CalcularLimiteDisponivel().
            Mostrar diferenças entre ContaPessoaFisica e ContaPessoaJuridica.

            Mostrar diferenças entre ContaPessoaFisica e ContaPessoaJuridica.
            um terá maior limite que o outro
            na PF, acréscimo de um cheque especial
            na PJ limite de 5000 + taxa conta de R$ 50,00
            */

            List<ContaBancaria> contas = new()
            {
                new ContaPessoaFisica("12345", "Juan Pablo Santos", 1000),
                new ContaPessoaJuridica("34567", "Impacta", 40000)
            };
            foreach(var conta in contas)
            {
                conta.ExibirResumo();
            }
        }
    }
}
