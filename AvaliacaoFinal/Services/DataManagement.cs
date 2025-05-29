using AvaliacaoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoFinal.Services
{
    public class DataManagement : IDataManagement
    {
        public Livro CadastrarLivro(string titulo, string autor, int id)
        {
            Console.WriteLine("O livro foi cadastrado com sucesso!");
            Console.WriteLine($"{titulo} - {autor} ID: {id}");
            return new Livro(titulo, autor, id);
        }
        public void LocarLivro(List<Livro> listadelivros, int id)
        {
            listadelivros.Find(livro => livro.Id == id).Estado = "Locado";
            Console.WriteLine("O livro foi locado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }
        public void DevolverLivro(List<Livro> listadelivros, int id)
        {
            Livro livroProcurado = listadelivros.Find(livro => livro.Id == id);
            if (livroProcurado.Estado == "Disponível")
            {
                Console.WriteLine("Esse livro não precisa ser devolvido!");
                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadKey();
            }
            else
            {
                livroProcurado.Estado = "Disponível";
                Console.WriteLine("Livro devolvido com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadKey();
            }
        }
        public void LivrosLocados(List<Livro> listadelivros)
        {
            foreach (Livro livro in listadelivros)
            {
                if (livro.Estado == "Locado")
                {
                    Console.WriteLine($"{livro.Titulo} - {livro.Autor} ID: {livro.Id}");
                }
            }
        }
        public void TodosLivros(List<Livro> listadelivros)
        {
            foreach (Livro livro in listadelivros)
            {
                Console.WriteLine($"{livro.Titulo} - {livro.Autor} ID: {livro.Id} Estado: {livro.Estado}");
            }
        }
    }
}
