using static System.Net.Mime.MediaTypeNames;

namespace Aula04_ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new(100, "Arnaldo", 200);
            /*
            conta1.Numero = 100;
            conta1.Titular = "Arnaldo";
            conta1.Saldo = 200;
            */

            Conta conta2 = new(200, "João Gabriel", 0);
            /*
            conta2.Numero = 200;
            conta2.Titular = "João Gabriel";
            conta2.Saldo = 0;
            */

            Conta conta3 = new(300, "Vitor", 1000);
            /*
            conta3.Numero = 300;
            conta3.Titular = "Vitor";
            conta3.Saldo = 1000;
            */

            /*
            Console.WriteLine("Banco Impacta");
            Console.WriteLine(new string('-', 30));
            conta1.ExibirSaldo();
            conta2.ExibirSaldo();
            conta3.ExibirSaldo();
            conta1.Sacar(200);
            conta1.ExibirSaldo();
            conta1.Depositar(1000);
            conta1.ExibirSaldo();
            */

            conta3.Transferir(700, conta2);

            conta1.ExibirSaldo();
            conta2.ExibirSaldo();
            conta3.ExibirSaldo();
        }
    }
}
