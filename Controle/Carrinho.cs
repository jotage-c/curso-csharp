using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle;

internal class Carrinho
{

    private List<Produto> itens = new List<Produto>();
    public void AdicionarProdutos(Produto produto, int quantidade)
    {
        if (!produto.VerificarEstoque(quantidade))
        {
            Console.WriteLine("Não há estoque para adicionar ao carrinho");
            return;
        }

        Produto itemCarrinho = produto.ClonarComQuantidade(quantidade);
        itens.Add(itemCarrinho);
        Console.WriteLine($"{quantidade} x {produto.Nome}");
    }

    public void ExibirCarrinho()
    {
        if (itens.Count == 0)
        {
            Console.WriteLine("Carrinho vazio");
            return;
        }

        Console.WriteLine("\n--- Carrinho de Compra ---");
        decimal total = 0;

        //percorrer a lista itens
        foreach (var item in itens)
        {
            Console.WriteLine($"" +
                $"{item.Nome} - {item.QuantidadeEmEstoque} x R$ {item.Preco}" +
                $" = R$ {item.Preco * item.QuantidadeEmEstoque}");
            total += item.Preco * item.QuantidadeEmEstoque;
        }
        Console.WriteLine($"Total da Compra: R$ {total}\n");
    }

    public void FinalizarCompra(List<Produto> produtos)
    {
        foreach (var item in itens)
        {
            var produtoOriginal = produtos.Find(p => p.Codigo == item.Codigo);
            if(produtoOriginal != null)
            {
                produtoOriginal.Vender(item.QuantidadeEmEstoque);
            }
            itens.Clear();
            Console.WriteLine("Compra Finalizada e estoque atualizado");
        }
    }
}
