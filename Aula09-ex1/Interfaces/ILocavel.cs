using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_ex1.Interfaces
{
    public interface ILocavel
    {
        string Modelo { get; }
        bool EstaDisponivel { get; }

        void Alugar();
        void Devolver();
    }
}
