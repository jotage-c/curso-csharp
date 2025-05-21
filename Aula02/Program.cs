namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estruturas de Controle");
            Console.WriteLine(new string('-', 30));

            Console.Write("Digite o valor do 1o número: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do 2o número: ");
            int b = int.Parse(Console.ReadLine());
            /*
            if (a < b)  //a é menor que b
            {
                Console.WriteLine("a é maior que b");
            } else
            {
                Console.WriteLine("a é menor que b");
            }
            */
            if (a > b)
            {
                Console.WriteLine("a é maior que b");
            }
            else if (a < b)
            {
                Console.WriteLine("a é menor que b");
            }
            else
            {
                Console.Write("a é igual a b");
            }
        }
    }
}
