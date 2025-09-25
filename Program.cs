using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua idade: ");
        int idadeCliente = int.Parse(Console.ReadLine());

        if (idadeCliente >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
        }
    }
}

