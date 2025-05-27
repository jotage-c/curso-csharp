using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_AplicacaoArquivos.Exceptions
{
    public class RespostaInvalidaException : Exception
    {
        public RespostaInvalidaException(string mensagem)
            : base(mensagem) { }
    }
}
