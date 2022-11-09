using System;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string coins = Console.ReadLine();

            double sum = 0;
            while (coins != "Start")
            {
                double currentCoins = double.Parse(coins);
                if (currentCoins == 0.1 || currentCoins == 0.2 
                    || currentCoins == 0.5 || currentCoins == 1 || currentCoins == 2)
                {
                    sum += currentCoins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentCoins}");
                }

                coins = Console.ReadLine();
            }

            string product = Console.ReadLine();
            double price = 0;
            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        price = 2.0;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;

                }
                if (price <= sum)
                {
                    sum = sum - price;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }

                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
