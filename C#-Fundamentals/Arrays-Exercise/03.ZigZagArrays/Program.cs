using System;
using System.Linq;

namespace _03.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrOne = new int[n];
            int[] arrTwo = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    arrOne[i] = numbers[0];
                    arrTwo[i] = numbers[1];
                }
                else
                {
                    arrOne[i] = numbers[1];
                    arrTwo[i] = numbers[0];
                }
            }

            Console.WriteLine(string.Join(" ", arrOne));
            Console.WriteLine(string.Join(" ", arrTwo));
        }
    }
}
