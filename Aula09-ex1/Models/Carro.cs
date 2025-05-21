using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_ex1.Models
{
    public class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }
        public Carro(string modelo, int numeroPortas) :base(modelo)
        {
            NumeroPortas = numeroPortas;
        }

        public override void Alugar()
        {
            base.Alugar();
            Console.WriteLine($"Carro '{Modelo}' com {NumeroPortas} portas foi alugado.");
        }

        public override void Devolver()
        {
            base.Devolver();
            Console.WriteLine($"Carro '{Modelo}' com {NumeroPortas} portas foi alugado.");
        }
    }
}
