using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int limit = Math.Min(firstNumbers.Count, secondNumbers.Count);
            int restValue = Math.Max(firstNumbers.Count, secondNumbers.Count);

            List<int> rezult = new List<int>();

            for (int i = 0; i < limit; i++)
            {
                rezult.Add(firstNumbers[i]);
                rezult.Add(secondNumbers[i]);

            }

            if (firstNumbers.Count != secondNumbers.Count)
            {
                for (int i = limit; i < restValue; i++)
                {
                    if (firstNumbers.Count >= secondNumbers.Count)
                    {
                        rezult.Add(firstNumbers[i]);

                    }
                    else
                    {
                        rezult.Add(secondNumbers[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", rezult));
        }
    }
}
