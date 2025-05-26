using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_AlunoTurmas.Delegates
{
    public delegate string FormatadorRelatorio(string cabecalho, string corpo);
    public class RelatorioDelegates
    {
        public static string FormatadorPadrao(string cabecalho, string corpo)
            => $"{cabecalho}\nnew string('-', 50)\n{corpo}\n";
        public static string FormatadorMaiusculo(string cabecalho, string corpo)
            => $"{cabecalho.ToUpper()}\nnew string('-', 50)\n{corpo.ToUpper()}\n";
    }
}
