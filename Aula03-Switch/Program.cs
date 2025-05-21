namespace Aula03_Switch
{
    internal class Program
    {
        enum Periodo
        {
            M, T, N
        }
        static void Main(string[] args)
        {
            Console.Write("Informe um valor de 1 a 7: ");
            string diaSemana = Console.ReadLine();
            string resultado = "";

            if (diaSemana.Trim() == "")
            {
                return;
            }
            switch (diaSemana)
            {
                case "1":
                    resultado = "Domingo";
                    break;
                case "2":
                    resultado = "Segunda";
                    break;
                case "3":
                    resultado = "Terça";
                    break;
                case "4":
                    resultado = "Quarta";
                    break;
                case "5":
                    resultado = "Quinta";
                    break;
                case "6":
                    resultado = "Sexta";
                    break;
                case "7":
                    resultado = "Sábado";
                    break;
                default:
                    resultado = "Valor errado ";
                    break;
            }
            Console.Write(resultado);

            //------------------------------------------------
            //expressions
            Periodo periodo = Periodo.M;
            string descricao;

            _ = (periodo switch
            {
                Periodo.M => descricao = "Manhã",
                Periodo.T => descricao = "Tarde",
                Periodo.N => descricao = "Noite",
                _ => descricao = "Período inválido"
            });

            Console.WriteLine("Periodo Informado: " + descricao);
            Console.ReadKey();
        }
    }
}
