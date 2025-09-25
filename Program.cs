using System;
using System.Collections.Generic;

class Aluno
{
    private List<double> notas = new List<double>();

    // Método para adicionar uma nota, com validação de intervalo (0 a 10)
    public void AdicionarNota(double nota)
    {
        if (nota >= 0 && nota <= 10)
        {
            notas.Add(nota);
        }
        else
        {
            Console.WriteLine("Nota inválida! Digite um valor entre 0 e 10.");
        }
    }

    // Método para calcular a média
    public double CalcularMedia()
    {
        if (notas.Count == 0)
        {
            return 0; // evita divisão por zero
        }

        double soma = 0;
        foreach (double nota in notas)
        {
            soma += nota;
        }
        return soma / notas.Count;
    }

    // Método para verificar aprovação
    public bool EstaAprovado()
    {
        return CalcularMedia() >= 6.0;
    }
}

class Program
{
    static void Main()
    {
        Aluno aluno = new Aluno();

        Console.WriteLine("Digite as notas do aluno (digite -1 para encerrar):");

        while (true)
        {
            Console.Write("Nota: ");
            double entrada = double.Parse(Console.ReadLine());

            if (entrada == -1) break;

            aluno.AdicionarNota(entrada);
        }

        double media = aluno.CalcularMedia();
        Console.WriteLine($"\nMédia do aluno: {media:F2}");

        if (aluno.EstaAprovado())
        {
            Console.WriteLine("Situação: Aprovado!");
        }
        else
        {
            Console.WriteLine("Situação: Reprovado!");
        }
    }
}
