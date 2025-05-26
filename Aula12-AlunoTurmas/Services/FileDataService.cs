using Aula12_AlunoTurmas.Delegates;
using Aula12_AlunoTurmas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aula12_AlunoTurmas.Services
{
    public class FileDataService : IDataService
    {
        private const string AlunosFile = "Data/alunos.txt";
        private const string TurmasFile = "Data/turmas.txt";
        public FileDataService()
        {
            // Garante que o diretório existe
            Directory.CreateDirectory("Data");
            // Cria os arquivos se não existirem
            if (!File.Exists(AlunosFile)) File.Create(AlunosFile).Close();
            if (!File.Exists(TurmasFile)) File.Create(TurmasFile).Close();
        }
        public void AdicionarAluno(Aluno aluno)
        {

            var linha =
            $"{ aluno.Id},{ aluno.Nome},{ aluno.Matricula},{aluno.TurmaId}";
            File.AppendAllLines(AlunosFile, new[] { linha });
        }
        public List<Aluno> ListarAlunos()
        {
            var linhas = File.ReadAllLines(AlunosFile);
            // Expressão lambda para transformar linhas em objetos Aluno
            return linhas.Select(linha =>
            {
                var dados = linha.Split(',');
                return new Aluno
                {
                    Id = int.Parse(dados[0]),
                    Nome = dados[1],
                    Matricula = dados[2],
                    TurmaId = int.Parse(dados[3])
                };
            }).ToList();
        }
        public List<Aluno> ListarAlunosPorTurma(int turmaId)
        {
            // Expressão lambda para filtrar alunos por turma
            return ListarAlunos().Where(a => a.TurmaId ==
            turmaId).ToList();
        }
        public void AdicionarTurma(Turma turma)
        {
            var linha = $"{ turma.Id},{ turma.Nome},{ turma.Codigo}";
            File.AppendAllLines(TurmasFile, new[] { linha });
        }
        public List<Turma> ListarTurmas()
        {
            var linhas = File.ReadAllLines(TurmasFile);
            return linhas.Select(linha =>
            {
                var dados = linha.Split(',');
                return new Turma
                {
                    Id = int.Parse(dados[0]),
                    Nome = dados[1],

                    Codigo = dados[2]
                };
            }).ToList();
        }
    }
}
