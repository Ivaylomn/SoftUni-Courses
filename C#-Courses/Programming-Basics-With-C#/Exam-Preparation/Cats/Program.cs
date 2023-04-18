using System;

namespace ExamTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountOfCats = int.Parse(Console.ReadLine());

            double group1 = 0;
            double group2 = 0;
            double group3 = 0;
            double countOfFood = 0;

            for (int i = 1; i <= CountOfCats; i++)
            {
                double food = double.Parse(Console.ReadLine());

                countOfFood += food;

                if (food >= 100 && food < 200)
                {
                    group1++;
                }
                else if (food >= 200 && food < 300)
                {
                    group2++;
                }
                else if (food >= 300 && food < 400)
                {
                    group3++;
                }
            }

            double pricePerDay = (countOfFood / 1000) * 12.45;

            Console.WriteLine($"Group 1: {group1} cats.");
            Console.WriteLine($"Group 2: {group2} cats.");
            Console.WriteLine($"Group 3: {group3} cats.");
            Console.WriteLine($"Price for food per day: {pricePerDay:f2} lv.");
        }
    }
}
