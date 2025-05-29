namespace Aula12_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Documentos\Arquivos\conteudo.txt";
            string texto = File.ReadAllText(path);
            Console.WriteLine(texto);
            Console.ReadKey();

            string[] linhas = File.ReadAllLines(path);
            foreach (var item in linhas)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            byte[] bytes = File.ReadAllBytes(path);
            for (int i = 0; i < bytes.Length; i++)
            {
                Console.Write(bytes[i] + " ");
                if (i > 0 && i % 20 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
