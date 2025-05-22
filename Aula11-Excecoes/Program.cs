namespace Aula11_Excecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3 };
            //Console.WriteLine(num[3]); // ArrayIndexOutOfRangeException

            int x = 10;
            int y = 0;
            //Console.WriteLine(x / y); // DivideByZeroException

            try
            {
                Console.Write("Digite um número inteiro: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Digite outro número inteiro: ");
                int b = int.Parse(Console.ReadLine());

                int resultado = a / b;
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Erro: Não é possível dividir por zero.");
                Console.WriteLine(ex.Message);
                Console.Write("Digite mais um número: ");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {10/c}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Levantou o erro: " + ex.Message);
            }
        }
    }
}
