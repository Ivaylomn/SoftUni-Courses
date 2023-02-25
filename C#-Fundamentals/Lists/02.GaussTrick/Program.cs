using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> sum = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                sum.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
            }

            if (numbers.Count % 2 == 1)
            {
                int element = numbers[numbers.Count / 2];
                sum.Add(element);
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
