using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double first = 0;
            double second = 0;
            double third = 0;
            double fourth = 0;
            double fifth = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    first++;
                }
                else if (number >= 200 && number <= 399)
                {
                    second++;
                }
                else if (number >= 400 && number <= 599)
                {
                    third++;
                }
                else if (number >= 600 && number <= 799)
                {
                    fourth++;
                }
                else
                {
                    fifth++;
                }
            }

            double p1 = first / n * 100;
            double p2 = second / n * 100;
            double p3 = third / n * 100;
            double p4 = fourth / n * 100;
            double p5 = fifth / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
