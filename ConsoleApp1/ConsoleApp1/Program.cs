using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите основание треугольника (см):");
        double baseTriangle = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите высоту треугольника (см):");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = (baseTriangle * height) / 2;
        Console.WriteLine($"Площадь треугольника: {area:F2} кв.см");
    }
}