namespace Aula11_ExcecaoArquivoNaoAchado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader leitor = new StreamReader(@"C:\Users\first informatica\Desktop\curso csh\Csharp\CursoCSHARP\Aula11-ExcecaoArquivoNaoAchado\dados.txt"))
                {
                    string conteudo = leitor.ReadToEnd();
                    Console.WriteLine("Conteúdo do arquivo\n" + conteudo);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo não encontrado");
                Console.ReadKey();
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro de Leitura: " + e.Message);
            }
        }
    }
}
