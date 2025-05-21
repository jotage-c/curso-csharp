namespace Aula03_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 1 - Condicional Simples
            // Solicite ao usuário que digite um número inteiro. 
            // Mostre na tela se esse número é positivo, negativo ou zero.

            /*
            Console.WriteLine("Execício 1");
            Console.WriteLine(new string('-', 30));

            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 0:
                    Console.WriteLine("O número é 0");
                    break;
                case < 0:
                    Console.WriteLine("O número é negativo");
                    break;
                default:
                    Console.WriteLine("O número é positivo");
                    break;
            }
            */

            // Exercício 2 - Laço de Repetição
            // Crie um programa que peça ao usuário um número inteiro positivo N 
            // e mostre todos os números pares de 0 até N (inclusive).

            /*
            Console.WriteLine("Exercício 2:");
            Console.Write("Digite um número inteiro positivo: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Números pares de 0 até " + n + ":");
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            */

            // Exercício 3 - Array com Média
            // Peça ao usuário para informar as notas de 5 alunos e armazene em um array.
            // Depois, calcule a média das notas e diga se a média da turma foi 
            // "Aprovada" (>= 7) ou "Reprovada" (< 7).

            /*
            Console.WriteLine("Informe as notas de 5 alunos:");
            double[] notas = new double[5];
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Aluno {i}: ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            double notasTotal = 0;
            foreach (double nota in notas)
            {
                notasTotal += nota;
            }
            double mediaTurma = notasTotal / 5;
            Console.WriteLine($"A média da turma foi {mediaTurma}");
            if (mediaTurma >= 7)
            {
                Console.Write("Situação da turma: Aprovada!");
            }
            else
            {
                Console.Write("Situação da turma: Reprovada :(");
            }
            */


            // Exercício 4 - Array com Busca e Condicional
            // Peça ao usuário para digitar 5 nomes e armazene em um array.
            // Depois, solicite um nome a ser buscado. Informe se o nome está na lista ou não.
            Console.WriteLine("Informe 5 nomes:");
            string[] nomes = new string[5];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Aluno {i}: ");
                nomes[i] = Console.ReadLine();
            }

            Console.Write("Pesquise por um nome: ");
            string nomeBuscado = Console.ReadLine();
            if (nomes.Contains(nomeBuscado))
            {
                Console.WriteLine($"{nomeBuscado} está na lista!");
            }
            else
            {
                Console.WriteLine("Esse nome não está na lista!");
            }
        }
    }
}
