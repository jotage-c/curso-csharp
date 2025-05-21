using Aula09_ex1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_ex1.Models
{
    public abstract class Veiculo : ILocavel
    {
        public string Modelo { get; set; }
        public bool EstaDisponivel { get; protected set; }

        public Veiculo(string modelo)
        {
            Modelo = modelo;
            EstaDisponivel = true;
        }

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
