using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_AlunoTurmas.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Codigo { get; set; }

        public override string ToString() => 
            $"Turma: {Id} - {Nome} ({Codigo})";
    }
}
