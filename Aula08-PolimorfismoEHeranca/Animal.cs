using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_PolimorfismoEHeranca
{
    internal class Animal
    {
        public string? Nome { get; set; }
        
        public void Comer()
        {
            Console.WriteLine($"{Nome} está comendo");
        }

        public virtual void EmitirSom()
        {
            Console.WriteLine($"{Nome} emitiu um som");
        }
    }
}
