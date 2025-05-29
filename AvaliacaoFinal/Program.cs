using AvaliacaoFinal.Models;
using AvaliacaoFinal.Services;

namespace AvaliacaoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ainda precisa de uns polimentos, mas essa versão funciona perfeitamente
            DataManagement dm = new();
            List<Livro> Livros = new();

            string? escolha;
            do
            {
                Console.WriteLine("--- Sistema de Locação de Livros ---\n");
                Console.WriteLine("1 - Cadastrar novo livro");
                Console.WriteLine("2 - Realizar locação");
                Console.WriteLine("3 - Realizar devolução");
                Console.WriteLine("4 - Listar livros locados");
                Console.WriteLine("5 - Listar todos os livros");
                Console.WriteLine("0 - Sair do sistema");
                Console.Write("\nSelecione alguma das opções: ");
                escolha = Console.ReadLine();

                switch(escolha)
                {
                    case "0":
                        Console.WriteLine("\nSaindo...\n");
                        return;

                    case "1":
                        //adicionar livro
                        Console.Write("Escreva o nome do livro a ser adicionado: ");
                        string nomeLivro = Console.ReadLine();
                        Console.Write("Escreva o nome do autor do livro a ser adicionado: ");
                        string nomeAutor = Console.ReadLine();
                        Console.Write("Escreva o ID do livro a ser adicionado: ");
                        int idLivro = int.Parse(Console.ReadLine());
                        Livros.Add(dm.CadastrarLivro(nomeLivro, nomeAutor, idLivro));
                        Console.WriteLine("Pressione qualquer tecla para continuar.");
                        Console.ReadKey();
                        break;

                    case "2":
                        //locar livro
                        Console.Write("Escreva o ID do livro a ser locado: ");
                        int idLocacao = int.Parse(Console.ReadLine());
                        dm.LocarLivro(Livros, idLocacao);
                        break;

                    case "3":
                        //devolver livro
                        Console.Write("Escreva o ID do livro a ser devolvido: ");
                        int idDevolucao = int.Parse(Console.ReadLine());
                        dm.DevolverLivro(Livros, idDevolucao);
                        break;

                    case "4":
                        //listar livros locados
                        Console.WriteLine("\n--- Lista de Livros Locados ---\n");
                        dm.LivrosLocados(Livros);
                        Console.WriteLine("\nPressione qualquer tecla para continuar.");
                        Console.ReadKey();
                        break;

                    case "5":
                        //listar livros
                        Console.WriteLine("\n--- Lista de Livros ---\n");
                        dm.TodosLivros(Livros);
                        Console.WriteLine("\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
            while (escolha != "0");
        }
    }
}
