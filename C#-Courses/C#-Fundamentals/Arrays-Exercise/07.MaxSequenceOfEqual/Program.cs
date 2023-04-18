using System;
using System.Linq;

namespace _07.MaxSequenceOfEqual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int currentEqualsElemnt = 1;
            int maxElemnt = 0;
            int element = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentEqualsElemnt++;
                }
                else
                {
                    currentEqualsElemnt = 1;
                }

                if (currentEqualsElemnt > maxElemnt)
                {
                    maxElemnt = currentEqualsElemnt;
                    element = numbers[i];
                }

            }

            for (int i = 0; i < maxElemnt; i++)
            {
                Console.Write(element + " ");
            }
        }
    }
}
