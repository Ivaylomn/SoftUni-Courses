using System;

namespace PbConditionalStatmentAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double price = 0;

            if (projection == "Premiere")
            {
                price = 12.00;
            }
            else if (projection == "Normal")
            {
                price = 7.50;
            }
            else
            {
                price = 5.00;
            }

            double income = r * c * price;

            Console.WriteLine($"{income:f2} leva");
        }
    }
}
