namespace Controle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>
            {
                new Produto(1, "Mouse Gamer", 15.87m, 10),
                new Produto(2, "Teclado", 10m, 20),
                new Produto(3, "Mouse Gamer", 39.99m, 15)
            };
            Carrinho carrinho = new Carrinho();

            int opcao = 0;

            do
            {
                Console.WriteLine("\n=== MENU DE CONTROLE DE ESTOQUE ===");
                Console.WriteLine("1 - Listar Produtos");
                Console.WriteLine("2 - Adicionar Produto ao Carrinho");
                Console.WriteLine("3 - Exibir Carrinho");
                Console.WriteLine("4 - Finalizar Compra");
                Console.WriteLine("5 - Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida.");
                    continue;
                }

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Produtos disponíveis: ");
                        foreach (var p in produtos)
                        {
                            p.ExibirInformacoes();
                        }
                        break;

                    case 2:
                        Console.Write("Digite o código do produto: ");
                        int cod = int.Parse(Console.ReadLine());
                        Produto? produtoselecionado = produtos.Find(p => p.Codigo == cod);
                        if (produtoselecionado == null)
                        {
                            Console.WriteLine("Produto não encontrado.");
                            break;
                        }
                        Console.Write("Digite a quantidade para adicionar ao Carrinho: ");
                        int qtd = int.Parse(Console.ReadLine());
                        carrinho.AdicionarProdutos(produtoselecionado, qtd);
                        break;

                    case 3:
                        carrinho.ExibirCarrinho();
                        break;

                    case 4:
                        carrinho.FinalizarCompra(produtos);
                        break;

                    case 5:
                        Console.WriteLine("Encerrando o programa...");
                        break;

                    default:
                        Console.WriteLine("Opção não encontrada.");
                        break;
                }

                Console.WriteLine("\nPressione ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();

            } while (opcao != 5);
        }
    }
}

