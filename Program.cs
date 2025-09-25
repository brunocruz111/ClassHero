using System;

class Program
{
    static void Main()
    {
        int pares = 0;
        int impares = 0;

        for (int i = 1; i <= 8; i++)
        {
            Console.Write($"Digite o {i}º número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
        }

        Console.WriteLine($"\nQuantidade de números pares: {pares}");
        Console.WriteLine($"Quantidade de números ímpares: {impares}");
    }
}
