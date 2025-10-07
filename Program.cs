using System;

public static class MathUtil
{
    /// <summary>
    /// Calcula o percentual de uma parte em relação a um total.
    /// Exemplo: Percent(25, 100) -> 25%
    /// </summary>
    public static double Percent(double parte, double total)
    {
        if (total == 0)
            throw new DivideByZeroException("O total não pode ser zero.");
        return (parte / total) * 100.0;
    }

    /// <summary>
    /// Restringe um valor a um intervalo [min, max].
    /// Exemplo: Clamp(15, 0, 10) -> 10
    /// </summary>
    public static double Clamp(double valor, double min, double max)
    {
        if (min > max)
            throw new ArgumentException("O valor mínimo não pode ser maior que o máximo.");
        if (valor < min) return min;
        if (valor > max) return max;
        return valor;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("===== Testes MathUtil =====\n");

        try
        {
            // 1️⃣ Percentual normal
            Console.WriteLine("Percent(25, 100) = " + MathUtil.Percent(25, 100)); // Esperado: 25

            // 2️⃣ Percentual com divisão por zero
            try
            {
                Console.WriteLine("Percent(10, 0) = " + MathUtil.Percent(10, 0));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Percent(10, 0) lançou exceção: " + ex.Message);
            }

            // 3️⃣ Clamp dentro do intervalo
            Console.WriteLine("Clamp(5, 0, 10) = " + MathUtil.Clamp(5, 0, 10)); // Esperado: 5

            // 4️⃣ Clamp abaixo do mínimo
            Console.WriteLine("Clamp(-3, 0, 10) = " + MathUtil.Clamp(-3, 0, 10)); // Esperado: 0

            // 5️⃣ Clamp acima do máximo
            Console.WriteLine("Clamp(15, 0, 10) = " + MathUtil.Clamp(15, 0, 10)); // Esperado: 10

            Console.WriteLine("\nTodos os testes foram executados com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro inesperado: " + ex.Message);
        }
    }
}
