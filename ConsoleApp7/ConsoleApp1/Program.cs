using System;

class Program
{
    static void Main()
    {
 
        Console.Write("Введите коэффициент a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double xVertex = -b / (2 * a);

        double yVertex = (-(b * b) + 4 * a * c) / (4 * a);

        Console.WriteLine($"Координаты вершины параболы: ({xVertex}, {yVertex})");
    }
}

