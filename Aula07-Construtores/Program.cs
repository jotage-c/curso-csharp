namespace Aula07_Construtores;

internal class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new("Juan Pablo", 49, 1.87, 105);
        Pessoa pessoa1 = new("Israel", 23, 1.90, 75);
        pessoa.GetPessoa();
        Console.WriteLine(new string('-', 30));
        pessoa1.GetPessoa();

        Console.ReadKey();
    }
}
