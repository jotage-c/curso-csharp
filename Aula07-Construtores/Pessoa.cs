using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07_Construtores;

internal class Pessoa
{
    ~Pessoa()
    {
        Console.WriteLine("Objeto Finalizado");
        Console.ReadKey();
    }
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }

    public Pessoa(double peso, double altura)
    {
        Peso = peso;
        Altura = altura;
    }

    public Pessoa(string nome, double peso, double altura) : this(peso, altura)
    {
        Nome = nome;
    }


    public Pessoa(string nome, int idade, double peso, double altura) : this(nome, peso, altura)
    {
        Idade = idade;
    }

    public void GetPessoa()
    {
        Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}" +
            $"\nPeso {Peso}\nAltura: {Altura}");
    }
    public void Exibir()
    {

    }
}
