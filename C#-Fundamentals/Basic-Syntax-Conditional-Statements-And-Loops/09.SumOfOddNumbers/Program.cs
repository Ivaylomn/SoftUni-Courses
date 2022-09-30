using System;

namespace _09.SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= num * 2; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                    sum = sum + i;
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
