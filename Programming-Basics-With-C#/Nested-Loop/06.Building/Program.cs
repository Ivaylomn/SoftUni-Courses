using System;

namespace _06Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floorCount = int.Parse(Console.ReadLine());
            int roomCount = int.Parse(Console.ReadLine());

            for (int floors = floorCount; floors >= 1; floors--)
            {
                for (int rooms = 0; rooms < roomCount; rooms++)
                {
                    if (floors == floorCount)
                    {
                        Console.Write($"L{floors}{rooms} ");

                        continue;
                    }

                    if (floors % 2 == 0)
                    {
                        Console.Write($"O{floors}{rooms} ");
                    }
                    else
                    {
                        Console.Write($"A{floors}{rooms} ");
                    }
                }

                Console.WriteLine();
            }

        }
    }
}
