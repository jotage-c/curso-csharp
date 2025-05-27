using Aula12_AplicacaoArquivos.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_AplicacaoArquivos.Services
{
    public class GerenciadorService : IGerenciadorService
    {
        public string path { get; } = @"C:\Users\USUARIO\source\repos\CursoCsharp\Aula12-AplicacaoArquivos\Data";

        public void CriarPasta()
        {
            //se a pasta já existe, ela não vai ser duplicada
            try
            {
                Directory.CreateDirectory(path);
            }
            catch (IOException)
            {
                return;
            }
        }
        public void CriarArquivo(string nome)
        {
            string newPath = path + @$"\{nome}.txt";
            StreamWriter writer = new StreamWriter(newPath);
            writer.Close();
            Console.WriteLine("Arquivo criado com sucesso!");
        }
        public void ApagarArquivo(string nome)
        {
            string newPath = path + @$"\{nome}.txt";
            if (!File.Exists(newPath))
            {
                throw new FileNotFoundException($"\nEsse arquivo não existe! Verifique o nome no caminho {path} (FileNotFoundException)\n");
                //não é para essa exceção ter tratamento
            }
            File.Delete(newPath);
            Console.WriteLine("\nArquivo deletado com sucesso!\n");
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
        }
        public void AcrescentarTexto(string nome, string texto)
        {
            string newPath = path + @$"\{nome}.txt";
            if (File.Exists(newPath))
            {
                Console.Write("Pular linha no fim do texto? (S/N): ");
                string pularLinha = Console.ReadLine().ToLower();
                StreamWriter writer = new StreamWriter(newPath);
                if(pularLinha == "s")
                {
                    writer.WriteLine(texto);
                }
                else if(pularLinha == "n")
                {
                    writer.Write(texto);
                }
                else
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
                    writer.Close();
                Console.WriteLine("Texto adicionado com sucesso!");
                Console.WriteLine("Aperte qualquer tecla para continuar.");
                Console.ReadKey();
            }
            else
            {
                throw new FileNotFoundException($"\nEsse arquivo não existe! Verifique o nome no caminho {path} (FileNotFoundException)\n");
            }
        }
        public void ListarArquivo(string nome)
        {
            string newPath = path + @$"\{nome}.txt";
            FileStream file = new FileStream(newPath, FileMode.Open);
            StreamReader reader = new(file);
            while (reader.Peek() != -1)
            {
                Console.Write((char)reader.Read()); //escreve o caractere lido
            }
            reader.Close();
            file.Close();
            Console.WriteLine("\n\nPressione qualquer tecla para continuar.");
            Console.ReadKey();
        }
    }
}
