using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Interface.Models
{
    public class Livro : Item
    {
        public string? Autor { get; set; }
        public string? Titulo { get; set; }
        public override void Alugar()
        {
            base.Alugar();
            Console.WriteLine($"Livro: {Titulo} foi alugado.");
        }
        public override void Devolver()
        {
            base.Devolver();
            Console.WriteLine($"Livro {Titulo} foi devolvido");
        }
    }
}
