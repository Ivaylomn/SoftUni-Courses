using System;

namespace _07._WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double secondsRecord = double.Parse(Console.ReadLine());
            double metersDistance = double.Parse(Console.ReadLine());
            double timeSecondsPerOneMeters = double.Parse(Console.ReadLine());

            double swims = metersDistance * timeSecondsPerOneMeters;
            double resistance = Math.Floor(metersDistance / 15) * 12.5;
            
            double totalTime = swims + resistance;

            if (secondsRecord <= totalTime)
            {
                double neededTime = totalTime - secondsRecord;
                Console.WriteLine($"No, he failed! He was {neededTime:f2} seconds slower.");
            }
            else if (secondsRecord > totalTime)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            
        }
    }
}
