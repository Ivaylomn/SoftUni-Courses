using System;

namespace _07._FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceStrawberries = double.Parse(Console.ReadLine());
            double kgBananas = double.Parse(Console.ReadLine());
            double kgOranges = double.Parse(Console.ReadLine());
            double kgRaspberries = double.Parse(Console.ReadLine());
            double kgStrawberries = double.Parse(Console.ReadLine());

            double sumStrawberries = kgStrawberries * priceStrawberries;

            double priceRaspberries = priceStrawberries / 2;

            double sumRaspberries = kgRaspberries * priceRaspberries;

            double priceBananas = priceRaspberries - 0.80 * priceRaspberries;
            double sumBananas = kgBananas * priceBananas;
            double priceOranges = priceRaspberries - 0.40 * priceRaspberries;
            double sumOranges = kgOranges * priceOranges;
            double totalPrice = sumStrawberries + sumRaspberries + sumBananas + sumOranges;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
