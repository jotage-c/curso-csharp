using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_ex1.Models
{
    public class Moto : Veiculo
    {
        public bool TemBagageiro {  get; set; }
        public Moto(string modelo, bool temBagageiro) : base(modelo)
        {
            TemBagageiro = temBagageiro;
        }

        public override void Alugar()
        {
            base.Alugar();
            Console.WriteLine($"Moto '{Modelo}' `{(TemBagageiro ? "com" : "sem")} bagageiro foi alugada.");
        }

        public override void Devolver()
        {
            base.Devolver();
            Console.WriteLine($"Moto '{Modelo}' foi devolvida.");
        }
    }
}
