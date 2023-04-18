using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // We read an arrays from console
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int sum = 0;

            // Iterate through all elements in the array with for loop.
            for (int i = 0; i < arr.Length; i++)
            {
                // Check that the number of the number from each element is even, we saved it in a variable.
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
