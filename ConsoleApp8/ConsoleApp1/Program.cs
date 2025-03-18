using System;

class Program
{
    static void Main()
    {
        double x = 2;
        double y = CalculateY(x);
        Console.WriteLine($"Значение y при x = {x}: {y}");
    }

    static double CalculateY(double x)
    {
        double part1 = Math.Tan(Math.Sqrt(Math.Log(Math.Exp(x + 1))));

        double denominator = Math.Sin(Math.Pow(x, 2)) - Math.Cos(Math.Pow(x, 2));
        if (denominator == 0)
        {
            Console.WriteLine("Ошибка: знаменатель выражения для part2 равен нулю.");
            return double.NaN; 
        }

        double part2 = (3 + Math.Sin(Math.Pow(x, 2))) / denominator;
        return part1 - part2;
    }
}

