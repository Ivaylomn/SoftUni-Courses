using System;

namespace _08OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int totalExamMinutes = examHour * 60 + examMinutes;
            int totalArrivalMinutes = arrivalHour * 60 + arrivalMinutes;
            int difference = totalArrivalMinutes - totalExamMinutes;
            int differenceTimeHour = Math.Abs(difference) / 60;
            int differenceTimeMinutes = Math.Abs(difference) % 60;

            if (difference > 0)
            {
                Console.WriteLine("Late");
                if (differenceTimeHour < 1)
                {
                    Console.WriteLine($"{differenceTimeMinutes} minutes after the start");
                }
                else
                    Console.WriteLine($"{differenceTimeHour}:{differenceTimeMinutes:d2} hours after the start");
            }
            else if (difference <= 0 && difference >= -30 && difference != 0)
            {
                Console.WriteLine("On time");
                if (differenceTimeHour < 1)
                {
                    Console.WriteLine($"{differenceTimeMinutes} minutes before the start");
                }
                else
                    Console.WriteLine($"{differenceTimeHour}:{differenceTimeMinutes:d2} hours before the start"); ;
            }
            else if (difference < -30)
            {
                Console.WriteLine("Early");
                if (differenceTimeHour < 1)
                {
                    Console.WriteLine($"{differenceTimeMinutes} minutes before the start");
                }
                else
                    Console.WriteLine($"{differenceTimeHour}:{differenceTimeMinutes:d2} hours before the start");
            }
            else if (difference == 0)
                Console.WriteLine("On time");
        }
    }
}
