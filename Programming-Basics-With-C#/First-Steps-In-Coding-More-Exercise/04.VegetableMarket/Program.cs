using System;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablesPricePerKg = double.Parse(Console.ReadLine());
            double fruitPricePerKg = double.Parse(Console.ReadLine());
            int totalVegetablesKg = int.Parse(Console.ReadLine());
            int totalFruitKg = int.Parse(Console.ReadLine());

            double income = (vegetablesPricePerKg * totalVegetablesKg + fruitPricePerKg * totalFruitKg) / 1.94;

            Console.WriteLine($"{income:f2}");
        }
    }
}
