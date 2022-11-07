using System;

namespace exercaiseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int number = i;
                while (number > 0)
                {
                    sum = sum + number % 10;
                    number = number / 10;
                }

                bool isTask = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isTask}");
            }
        }
    }
}
