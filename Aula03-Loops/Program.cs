namespace Aula03_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //loop for
            /*
           for (int a = 1, b = 1; (a < 300 && b < 300); a *= 3, b *= 2)
           {
               Console.WriteLine("Valor a: " + a);
               Console.WriteLine("Valor b: " + b);
               Console.WriteLine(new string('-', 30));
           }
           Console.ReadKey();
           */
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }


            //------------------------------------------------------------------------------------------


            string[] lista = { "Brasil", "Alemanha", "México", "Chile", "Holanda", "Colômbia", "Argentina", "Uruguai" };
            foreach(string pais in lista)
            {
                Console.WriteLine(pais);
            }


            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }



            //------------------------------------------------------------------------------------------

            //while
            int a = 0;
            while (a < lista.Length)
            {
                Console.WriteLine(lista[a]);
                a++;
            }
        }
    }
}
