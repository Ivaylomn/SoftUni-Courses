using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double punds = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(decimal)punds * 1.31M:F3}");
        }
    }
}
