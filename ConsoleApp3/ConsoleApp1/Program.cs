using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine());

        if (x < 3)
        {
            Console.WriteLine("Ошибка: x должно быть >= 3, чтобы выражения были корректными.");
            return;
        }

        double numerator1 = Math.Pow(x, 2) + 2 * x - 3 + (x + 1) * Math.Sqrt(Math.Pow(x, 2) - 9);
        double denominator1 = Math.Pow(x, 2) - 2 * x - 3 + (x - 1) * Math.Sqrt(Math.Pow(x, 2) - 9);
        double z1 = numerator1 / denominator1;

        double z2 = Math.Sqrt((x + 3) / (x - 3));

        Console.WriteLine($"z1 = {z1:F4}");
        Console.WriteLine($"z2 = {z2:F4}");
    }
}

