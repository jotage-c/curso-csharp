using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_PolimorfismoEHeranca
{
    class Gato : Animal
    {
        public override void EmitirSom() { Console.WriteLine($"{Nome} está miando"); }
    }
}
