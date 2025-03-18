using System;

class Program
{
    static void Main()
    {
        double x = 2;
        double sqrtPart = Math.Sqrt(Math.Log(Math.Exp(x) + 1));
        double numerator = 3 + Math.Pow(Math.Sin(x), 2);
        double denominator = Math.Pow(Math.Sin(x), 2) - Math.Pow(Math.Cos(x), 2);

        if (denominator == 0)
        {
            Console.WriteLine("Ошибка: деление на ноль.");
            return;
        }

        double y = Math.Tan(sqrtPart) - (numerator / denominator);

        Console.WriteLine($"Значение функции при x = {x}: y = {y:F4}");
    }
}

