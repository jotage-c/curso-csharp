using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_AplicacaoArquivos.Services
{
    public interface IGerenciadorService
    {
        public void CriarPasta();
        public void CriarArquivo(string nome);
        public void ApagarArquivo(string nome);
        public void AcrescentarTexto(string nome, string texto);
        public void ListarArquivo(string nome);

    }
}
