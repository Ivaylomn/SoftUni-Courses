using System;

namespace _09Volleybal
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double sofiaSaturdays = (48 - h) * (double)3 / 4;
            double saturdays = (holidays * (double)2 / 3);
            double total = sofiaSaturdays + h + saturdays;

            switch (yearType)
            {
                case "leap":
                    total *= 1.15;
                    break;
            }
            Console.WriteLine(Math.Floor(total));
        }
    }
}
