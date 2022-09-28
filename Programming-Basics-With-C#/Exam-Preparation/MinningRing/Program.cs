using System;

namespace MinningRing
{
    class Program
    {
        static void Main(string[] args)
        {
            int videoCard = int.Parse(Console.ReadLine()) * 13;
            int adapter = int.Parse(Console.ReadLine()) * 13;
            double electricity = double.Parse(Console.ReadLine());
            double income = (double.Parse(Console.ReadLine()) - electricity) * 13;

            double costs = videoCard + adapter + 1000;
            double days = Math.Ceiling(costs / income);

            Console.WriteLine(costs);
            Console.WriteLine(days);
        }
    }
}
