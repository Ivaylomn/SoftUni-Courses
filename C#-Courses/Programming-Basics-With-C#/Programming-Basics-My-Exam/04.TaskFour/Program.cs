using System;

namespace _04Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int catsCount = int.Parse(Console.ReadLine());

            int smallCat = 0;
            int bigCat = 0;
            int biggestCat = 0;
            double sum = 0;

            for (int i = 0; i < catsCount; i++)
            {
                double xFoodGr = double.Parse(Console.ReadLine());

                if (xFoodGr >= 100 && xFoodGr < 200)
                {
                    smallCat++;
                }
                else if (xFoodGr >= 200 && xFoodGr < 300)
                {
                    bigCat++;
                }
                else if (xFoodGr >= 300 && xFoodGr < 400)
                {
                    biggestCat++;
                }

                sum += xFoodGr;
            }

            double quantityFodd = (sum / 1000) * 12.45;

            Console.WriteLine($"Group 1: {smallCat} cats.");
            Console.WriteLine($"Group 2: {bigCat} cats.");
            Console.WriteLine($"Group 3: {biggestCat} cats.");
            Console.WriteLine($"Price for food per day: {Math.Round(quantityFodd, 2)} lv.");
        }
    }
}
