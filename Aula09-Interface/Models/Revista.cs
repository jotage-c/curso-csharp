using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Interface.Models
{
    public class Revista : Item
    {
        public int Edicao { get; set; }
        public string? Titulo { get; set; }

        public override void Alugar()
        {
            base.Alugar();
            Console.WriteLine($"Revista {Titulo} Edição {Edicao} foi alugada");
        }
    }
}
