using System;

namespace _06Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int locationCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < locationCount; i++)
            {
                double averageGold = double.Parse(Console.ReadLine());
                int daysCount = int.Parse(Console.ReadLine());

                double sum = 0;
                for (int j = 0; j < daysCount; j++)
                {
                    double goldPerDay = double.Parse(Console.ReadLine());
                    sum += goldPerDay;
                }

                double averegePerDay = sum / daysCount;

                if (averegePerDay >= averageGold)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averegePerDay:F2}.");
                }
                else
                {
                    Console.WriteLine($"You need {averageGold - averegePerDay:f2} gold.");
                }
            }
        }
    }
}
