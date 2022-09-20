using System;

namespace _03NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceForFlowers = 0;
            double discount = 0;
            double totalSum = 0;

            switch (flowers)
            {
                case "Roses":
                    priceForFlowers = 5.00;
                    totalSum = countOfFlowers * priceForFlowers;
                    if (countOfFlowers > 80)
                    {
                        discount = totalSum * 10 / 100;
                        totalSum = totalSum - discount;
                    }
                    break;
                case "Dahlias":
                    priceForFlowers = 3.80;
                    totalSum = countOfFlowers * priceForFlowers;
                    if (countOfFlowers > 90)
                    {
                        discount = totalSum * 15 / 100;
                        totalSum = totalSum - discount;
                    }
                    break;
                case "Tulips":
                    priceForFlowers = 2.80;
                    totalSum = countOfFlowers * priceForFlowers;
                    if (countOfFlowers > 80)
                    {
                        discount = totalSum * 15 / 100;
                        totalSum = totalSum - discount;

                    }
                    break;
                case "Narcissus":
                    priceForFlowers = 3.00;
                    totalSum = countOfFlowers * priceForFlowers;
                    if (countOfFlowers < 120)
                    {
                        discount = totalSum * 15 / 100;
                        totalSum = totalSum + discount;
                    }
                    break;
                case "Gladiolus":
                    priceForFlowers = 2.50;
                    totalSum = countOfFlowers * priceForFlowers;
                    if (countOfFlowers < 80)
                    {
                        discount = totalSum * 20 / 100;
                        totalSum = totalSum + discount;
                    }
                    break;
                default:
                    break;
            }

            if (budget >= totalSum)
            {
                Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {flowers} and {budget - totalSum:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalSum - budget:F2} leva more.");
            }
        }
    }
}
