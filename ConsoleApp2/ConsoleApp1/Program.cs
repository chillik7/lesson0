using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите трехзначное число:");
        int number = Convert.ToInt32(Console.ReadLine());

        int firstDigit = number / 100; 
        int remainingDigits = number % 100; 

        int newNumber = remainingDigits * 10 + firstDigit;
        Console.WriteLine($"Новое число: {newNumber}");
    }
}
