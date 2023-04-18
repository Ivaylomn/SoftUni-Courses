using System;
using System.Diagnostics.CodeAnalysis;

namespace _05AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            double total = 0.0;
            while (text != "NoMoreMoney")
            {
                double num = double.Parse(text);

                if (num < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {text}");

                total = total + num;

                text = Console.ReadLine();
            }

            Console.WriteLine($"Total: {total:F2}");
        }
    }
}
