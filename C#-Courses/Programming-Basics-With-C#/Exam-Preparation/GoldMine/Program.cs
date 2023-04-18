using System;

namespace GoldMine
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLocation = int.Parse(Console.ReadLine());

            double totalGold = 0;
            for (int i = 0; i < numLocation; i++)
            {
                double averageGoldAboutDay = double.Parse(Console.ReadLine());
                int numDaysInThatLocation = int.Parse(Console.ReadLine());

                double averageGoldForDay = 0;
                for (int day = 0; day < numDaysInThatLocation; day++)
                {
                    double goldForDay = double.Parse(Console.ReadLine());

                    averageGoldForDay = averageGoldForDay + goldForDay / numDaysInThatLocation;
                    totalGold = averageGoldForDay;
                }
                if (averageGoldForDay >= averageGoldAboutDay)
                {
                    Console.WriteLine($"Good job! Average gold per day: {totalGold:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {Math.Abs(averageGoldAboutDay - totalGold):f2} gold.");
                }
            }
        }
    }
}
