using System;

namespace _04FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanCount = int.Parse(Console.ReadLine());

            double priceForRent = 0;
            
            switch (season)
            {
                case "Spring":
                    priceForRent = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    priceForRent = 4200;
                    break;
                case "Winter":
                    priceForRent = 2600;
                    break;
                default:
                    break;
            }

            double discount = 0;
            if (fishermanCount <= 6)
            {
                discount = priceForRent * 10 / 100;
                priceForRent = priceForRent - discount;
            }
            else if (fishermanCount <= 11)
            {
                discount = priceForRent * 15 / 100;
                priceForRent = priceForRent - discount;
            }
            else
            {
                discount = priceForRent * 25 / 100;
                priceForRent = priceForRent - discount;
            }

            if (fishermanCount % 2 == 0 && season != "Autumn")
            {
                discount = priceForRent * 5 / 100;
                priceForRent = priceForRent - discount;
            }

            if (budget >= priceForRent)
            {
                double moneyLeft = budget - priceForRent;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeed = priceForRent - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeed:f2} leva.");
            }
           

        }
    }
}
