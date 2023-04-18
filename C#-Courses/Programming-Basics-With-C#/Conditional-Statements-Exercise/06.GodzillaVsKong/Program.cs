using System;

namespace _6.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int staticCount = int.Parse(Console.ReadLine());
            double priceClothForOneStatic = double.Parse(Console.ReadLine());

            double decorPrice = budget * 10 / 100;
            double clothPrice = staticCount * priceClothForOneStatic;
            double totalSum = decorPrice + clothPrice;

            if (staticCount >= 150)
            {
                double discount = clothPrice * 10 / 100;
                clothPrice = clothPrice - discount;
            }
            if (decorPrice >= budget || clothPrice >= budget )
            {
                totalSum = decorPrice + clothPrice;
                double needMoney = totalSum - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {needMoney:F2} leva more.");
            }
            else if (decorPrice <= budget && clothPrice <= budget)
            {
                totalSum = decorPrice + clothPrice;
                double leftMoney = budget - totalSum;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {leftMoney:F2} leva left.");
            }
            
        }
    }
}
