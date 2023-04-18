using System;

namespace _02Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int bottleBeerCount = int.Parse(Console.ReadLine());
            int chipsCount = int.Parse(Console.ReadLine());

            double totalBeerPrice = bottleBeerCount * 1.20;
            double chipsPrice = totalBeerPrice * 0.45;
            double totalChipsPrice = Math.Ceiling(chipsPrice * chipsCount);
            double totalMoney = totalBeerPrice + totalChipsPrice;

            if (totalMoney <= budget)
            {
                double leftMoney = budget - totalMoney;
                Console.WriteLine($"{name} bought a snack and has {leftMoney:F2} leva left.");
            }
            else
            {
                double neededMoney =totalMoney - budget;
                Console.WriteLine($"{name} needs {neededMoney:f2} more leva!");
            }


        }
    }
}
