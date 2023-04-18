using System;

namespace _05Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());

            double sum = 0.0;
            while (destination != "End")
            {
               
                double money = double.Parse(Console.ReadLine());

                sum += money;

                if (sum >= budget)
                {
                    Console.WriteLine($"Going to {destination}!");

                    destination = Console.ReadLine();

                    if (destination == "End")
                    {
                        break;
                    }

                    budget = double.Parse(Console.ReadLine());

                    sum = 0;
                }
            }
        }
    }
}
