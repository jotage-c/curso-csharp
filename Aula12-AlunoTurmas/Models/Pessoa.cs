using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_AlunoTurmas.Models
{
    public abstract class Pessoa
    {
        //encapsulamento campos privados com propriedades públicas
        
        private string _nome { get; set; }
        // _ é uma nomenclatura que indica que a propriedade é privada
        // ela só pode ser modificada dentro da própria classe

        private int _id;

        public int Id
        {
            get => _id;
            set => _id = value > 0 ? value : 
                throw new ArgumentException("ID deve ser positivo");
        }
        public string Nome
        {
            get => _nome;
            set => _nome = !string.IsNullOrWhiteSpace(value) ?
                value : throw new ArgumentException("Nome não pode ser vazio");
        }

        //polimorfismo
        public virtual string ObterInformacoes() => $"Id: {Id}, {Nome}";
    }
}
