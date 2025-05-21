using Aula09_Interface.Models;
using Aula09_Interface.Services;

namespace Aula09_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente() { Nome = "Juan" };

            ILocavel livro = new Livro()
            {
                Titulo = "C# do Zero ao Deploy",
                Autor = "Arnaldo Domingues"
            };

            ILocavel revista = new Revista()
            {
                Titulo = "Impacta Global",
                Edicao = 100
            };
            LocacaoService lS = new LocacaoService();
            LocacaoService LSR = new LocacaoService();
            lS.LocarItem(c1, livro);
            LSR.LocarItem(c1, revista);
        }
    }
}
