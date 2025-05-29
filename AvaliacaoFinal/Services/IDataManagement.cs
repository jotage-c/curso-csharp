using AvaliacaoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoFinal.Services
{
    public interface IDataManagement
    {
        public Livro CadastrarLivro(string titulo, string autor, int id);
        public void LocarLivro(List<Livro> listadelivros, int id);
        public void DevolverLivro(List<Livro> listadelivros, int id);
        public void LivrosLocados(List<Livro> listadelivros);
        public void TodosLivros(List<Livro> listadelivros);
    }
}
