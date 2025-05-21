using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Interface.Models
{
    public interface ILocavel
    {
        public string Titulo { get; }
        public bool EstaDisponivel { get; set; }
        public void Alugar();
        public void Devolver();
    }
}
