using System;

namespace _10OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evenNumber = 0;
            int oddNumber = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenNumber += number;
                }
                else
                {
                    oddNumber += number;
                }
            }

            if (oddNumber == evenNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenNumber}");
            }
            else
            {
                double differnt = evenNumber - oddNumber;
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(differnt)}");
            }
        }
    }
}
