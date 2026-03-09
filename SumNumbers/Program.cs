using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть перше число:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Сума чисел: {a + b}");
        
        Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}