using System.Threading.Channels;

namespace Aula11_ExcecaoCustomizada
{
    public class SenhaInvalidaException : Exception
    {
        public SenhaInvalidaException(string mensagem)
            : base(mensagem) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite a senha: ");
                string senha = Console.ReadLine();
                ValidarSenha(senha);
            }
            catch (SenhaInvalidaException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

            void ValidarSenha(string senha)
            {
                if (senha.Length < 6)
                    throw new SenhaInvalidaException("senha deve ter 6 digitos no minimo");

            }
        }
    }
}
