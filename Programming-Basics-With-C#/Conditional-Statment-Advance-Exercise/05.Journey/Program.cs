using System;

namespace _05Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string rest = "";
            double discount = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    rest = "Camp";
                    discount = budget * 30 / 100;
                }
                else if (season == "winter")
                {
                    rest = "Hotel";
                    discount = budget * 70 / 100;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    rest = "Camp";
                    discount = budget * 40 / 100;
                }
                else if (season == "winter")
                {
                    rest = "Hotel";
                    discount = budget * 80 / 100;
                }
            }
            else
            {
                destination = "Europe";
                rest = "Hotel";
                discount = budget * 90 / 100;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{rest} - {discount:f2}");
        }
    }
}
