using Aula12_AplicacaoArquivos.Exceptions;
using Aula12_AplicacaoArquivos.Services;
using System.IO;

namespace Aula12_AplicacaoArquivos;

internal class Program
{
    static void Main(string[] args)
    {
        //usei camelcase pra eu não confundir as vars com métodos
        string? escolha;

        GerenciadorService ger = new();
        ger.CriarPasta();
        do
        {
            Console.WriteLine("--- Gerenciador de Arquivos de Texto (v. Alpha) ---\n");
            Console.WriteLine("1 - Criar Arquivo");
            Console.WriteLine("2 - Apagar Arquivo");
            Console.WriteLine("3 - Acrescentar Texto em um Arquivo");
            Console.WriteLine("4 - Listar Conteúdo de um Arquivo");
            Console.WriteLine("5 - Sair");
            Console.Write("\nDigite o número da sua próxima ação: ");
            escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.Write("Digite um nome para o arquivo: ");
                    string? nomeArquivoCriar = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nomeArquivoCriar))
                    {
                        try
                        {
                            throw new RespostaInvalidaException("\nVocê digitou uma resposta inválida! (RespostaInvalidaException)\n");
                        }
                        catch (RespostaInvalidaException ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Pressione qualquer tecla para tentar mais uma vez.");
                            Console.ReadKey();
                            break;
                        }
                    }
                    ger.CriarArquivo(nomeArquivoCriar);
                    Console.Write("Deseja realizar mais alguma ação? (S/N): ");
                    string? resposta = Console.ReadLine().ToLower();
                    if (resposta == "n")
                    {
                        return;
                    }
                    else if (resposta != "s")
                    {
                        try
                        {
                            throw new RespostaInvalidaException("\nVocê digitou uma resposta inválida! (RespostaInvalidaException)\n");
                        }
                        catch (RespostaInvalidaException ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Pressione qualquer tecla para tentar mais uma vez.");
                            Console.ReadKey();
                        }
                    }
                    break;

                case "2":
                    Console.Write("Digite o nome do arquivo a ser apagado: ");
                    string? nomeArquivoApagar = Console.ReadLine();
                    ger.ApagarArquivo(nomeArquivoApagar);
                    break;

                case "3":
                    Console.Write("Digite o nome do arquivo a ter texto acrescentado: ");
                    string nomeArquivoVerificar = Console.ReadLine();
                    Console.WriteLine("Digite o texto a ser acrescentado:");
                    string? novoTexto = Console.ReadLine();
                    ger.AcrescentarTexto(nomeArquivoVerificar, novoTexto);
                    break;

                case "4":
                    Console.Write("Digite o nome do arquivo a ser listado: ");
                    string? nomeArquivoListar = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nomeArquivoListar))
                    {
                        try
                        {
                            throw new RespostaInvalidaException("\nVocê digitou uma resposta inválida! (RespostaInvalidaException)\n");
                        }
                        catch (RespostaInvalidaException ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine("Pressione qualquer tecla para tentar mais uma vez.");
                            Console.ReadKey();
                            break;
                        }
                    }
                    ger.ListarArquivo(nomeArquivoListar);
                    break;

                case "5":
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    try
                    {
                        throw new RespostaInvalidaException("\nVocê digitou uma resposta inválida! (RespostaInvalidaException)\n");
                    }
                    catch (RespostaInvalidaException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Pressione qualquer tecla para tentar mais uma vez.");
                        Console.ReadKey();
                    }
                    break;
            }
            Console.Clear();
        }
        while (escolha != "5");
    }
}
