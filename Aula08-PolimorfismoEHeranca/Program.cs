
namespace Aula08_PolimorfismoEHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            var dog = new Cachorro();
            dog.Nome = "Obelix";
            dog.EmitirSom();

            var cat = new Gato();
            cat.Nome = "Manda-Chuva";
            cat.EmitirSom();
            */
            List<Animal> animais = new List<Animal>
            {
                new Gato(),
                new Cachorro()
            };
            foreach (var animal in animais)
            {
                animal.EmitirSom();
            }
        }
    }
}
