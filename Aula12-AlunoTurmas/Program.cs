using Aula12_AlunoTurmas.Delegates;
using Aula12_AlunoTurmas.Models;
using Aula12_AlunoTurmas.Services;
using System.ComponentModel;

namespace Aula12_AlunoTurmas
{
    internal class Program
    {
        private static IDataService _dataService;
        private static FormatadorRelatorio _formatador;
        static void Main(string[] args)
        {
            InitializeServices();
            RunApplication();
        }
        private static void InitializeServices()
        {
            _dataService = new FileDataService();
            _formatador = RelatorioDelegates.FormatadorPadrao;
            // Adiciona dados iniciais se os arquivos estiverem vazios
            SeedInitialData();
        }
        private static void SeedInitialData()
        {
            if (!_dataService.ListarTurmas().Any())
            {
                _dataService.AdicionarTurma(new Turma
                {
                    Id = 1,
                    Nome = "Turma A",
                    Codigo = "TURMA2023A"
                });
                _dataService.AdicionarTurma(new Turma
                {
                    Id = 2,
                    Nome = "Turma B",
                    Codigo = "TURMA2023B"
                });
            }
            if (!_dataService.ListarAlunos().Any())
            {
                _dataService.AdicionarAluno(new Aluno
                {
                    Id = 1,
                    Nome = "João Silva",
                    Matricula = "MAT001",
                    TurmaId = 1
                });
                _dataService.AdicionarAluno(new Aluno
                {
                    Id = 2,
                    Nome = "Maria Souza",
                    Matricula = "MAT002",
                    TurmaId = 1
                });
                _dataService.AdicionarAluno(new Aluno
                {
                    Id = 3,
                    Nome = "Carlos Oliveira",
                    Matricula = "MAT003",
                    TurmaId = 2
                });
            }
        }
        private static void RunApplication()
        {
            while (true)
            {
                DisplayMenu();
                var opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        ListarTurmas();
                        break;

                    case "2":
                        ListarAlunosPorTurma();
                        break;
                    case "3":
                        AdicionarTurma();
                        break;
                    case "4":
                        AdicionarAluno();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
        private static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("Sistema de Gerenciamento de Alunos e Turmas");
            Console.WriteLine("1.Listar todas as turmas");
            Console.WriteLine("2.Listar alunos de uma turma");
            Console.WriteLine("3.Adicionar nova turma");
            Console.WriteLine("4.Adicionar novo aluno");
            Console.WriteLine("5.Sair");
            Console.Write("Escolha uma opção: ");
        }
        private static void ListarTurmas()
        {
            var turmas = _dataService.ListarTurmas();
            var cabecalho = "Lista de Turmas Cadastradas";
            var corpo = string.Join("\n", turmas.Select(t => t.ToString()));
            Console.WriteLine(_formatador(cabecalho, corpo));
        }
        private static void ListarAlunosPorTurma()
        {
            Console.Write("Digite o ID da turma: ");
            if (int.TryParse(Console.ReadLine(), out int turmaId))
            {
                var turma = _dataService.ListarTurmas().FirstOrDefault(t => t.Id == turmaId);
                if (turma != null)
                {
                    var alunos = _dataService.ListarAlunosPorTurma(turmaId);
                    var cabecalho = $"Alunos da Turma { turma.Nome}";
                    var corpo = string.Join("\n", alunos.Select(a => a.ObterInformacoes()));
                    // Adiciona formatador maiúsculo temporariamente
                    _formatador += RelatorioDelegates.FormatadorMaiusculo;
                    Console.WriteLine(_formatador(cabecalho, corpo));
                    // Remove o formatador maiúsculo
                    _formatador -= RelatorioDelegates.FormatadorMaiusculo;
                }
                else
                {
                    Console.WriteLine("Turma não encontrada!");

                }
            }
            else
            {
                Console.WriteLine("ID inválido!");
            }
        }
        private static void AdicionarTurma()
        {
            Console.WriteLine("Cadastro de Nova Turma");
            var turma = new Turma();
            Console.Write("ID: ");
            turma.Id = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nome: ");
            turma.Nome = Console.ReadLine() ?? "";
            Console.Write("Código: ");
            turma.Codigo = Console.ReadLine() ?? "";
            _dataService.AdicionarTurma(turma);
            Console.WriteLine("Turma cadastrada com sucesso!");
        }
        private static void AdicionarAluno()
        {
            Console.WriteLine("Cadastro de Novo Aluno");
            var aluno = new Aluno();
            Console.Write("ID: ");
            aluno.Id = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine() ?? "";
            Console.Write("Matrícula: ");
            aluno.Matricula = Console.ReadLine() ?? "";
            Console.Write("ID da Turma: ");
            aluno.TurmaId = int.Parse(Console.ReadLine() ?? "0");
            _dataService.AdicionarAluno(aluno);
            Console.WriteLine("Aluno cadastrado com sucesso!");
        }
    }
}
