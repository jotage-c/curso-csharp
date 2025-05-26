using Aula12_AlunoTurmas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_AlunoTurmas.Services
{
    public interface IDataService
    {
        void AdicionarAluno(Aluno aluno);
        List<Aluno> ListarAlunos();
        List<Aluno> ListarAlunosPorTurma(int turmaId);
        void AdicionarTurma(Turma turma);
        List<Turma> ListarTurmas();
    }
}
