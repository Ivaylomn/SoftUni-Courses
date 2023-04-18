using System;

namespace _06._CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCake = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());

            double cakes = numberOfCake * 45;
            double waffles = numberOfWaffles * 5.80;
            double pancakes = numberOfPancakes * 3.20;
            double total = cakes + waffles + pancakes * 8;
            double amountCollected = total * 23;
            double totalSum = amountCollected / 8;
            Console.WriteLine(totalSum);

        }
    }
}
