using System;

namespace _07._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());

            double totalPrice = numberOfPuzzles * 2.60 + numberOfDolls * 3 + numberOfBears * 4.10 + numberOfMinions * 8.20 + numberOfTrucks * 2;

            int numOfToys = numberOfPuzzles + numberOfDolls + numberOfBears + numberOfMinions + numberOfTrucks;

            if (numOfToys >= 50)
            {
                totalPrice *= 0.75;
            }

            totalPrice -= totalPrice * 0.10;
            if (totalPrice >= excursionPrice)
            {
                Console.WriteLine($"Yes! {totalPrice - excursionPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {excursionPrice - totalPrice:f2} lv needed.");
            }
        }
    }
}
