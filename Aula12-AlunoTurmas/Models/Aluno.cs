using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_AlunoTurmas.Models
{
    public class Aluno : Pessoa
    {
        public string? Matricula { get; set; }
        public int TurmaId { get; set; }

        public override string ObterInformacoes() => 
            $"{base.ObterInformacoes()}, Matrícula: {Matricula}, Turma: {TurmaId}";
    }
}
