using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Interface.Models
{
    public abstract class Item : ILocavel
    {
        public string? Titulo { get; }
        public bool EstaDisponivel { get; set; } = true;
        public virtual void Alugar()
        {
            EstaDisponivel = false;
        }
        public virtual void Devolver()
        {
            EstaDisponivel = true;
        }
    }
}
