using System;
using System.Linq;

namespace _06.EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int sumEvenNumbers = 0;
            int sumOddNumbers = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sumEvenNumbers += arr[i];
                }
                else
                {
                    sumOddNumbers += arr[i];
                }
            }

            Console.WriteLine($"{sumEvenNumbers - sumOddNumbers}");
        }
    }
}
