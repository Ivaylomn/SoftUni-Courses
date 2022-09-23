using System;

namespace _08NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input < minNumber)
                {
                    minNumber = input;
                }
                if (input > maxNumber)
                {
                    maxNumber = input;
                }
            }

            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
