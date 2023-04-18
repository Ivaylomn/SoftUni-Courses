using System;
using System.Linq;

namespace probenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split(" ").Select(int.Parse) .ToArray();
            int[] arrayTwo = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }

            }
            //Sum all numbers in array with metods.
            int sum = arrayOne.Sum();

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }

    }
}