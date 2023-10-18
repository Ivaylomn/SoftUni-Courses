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
                int sumOfDigit = 0;
                int number = i;

                while (number > 0)
                {
                    sumOfDigit += number % 10;
                    number /= 10;
                }

                bool isSpecial = sumOfDigit == 5 || sumOfDigit == 7 || sumOfDigit == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
