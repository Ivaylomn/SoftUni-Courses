using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();


            while (firstPlayer.Count != 0 && secondPlayer.Count != 0)
            {
                int firstCardPlayer = firstPlayer[0];
                int secondCardPlayer = secondPlayer[0];

                if (firstCardPlayer > secondCardPlayer)
                {
                    firstPlayer.Add(firstCardPlayer);
                    firstPlayer.Add(secondCardPlayer);
                }
                else if (secondCardPlayer > firstCardPlayer)
                {
                    secondPlayer.Add(secondCardPlayer);
                    secondPlayer.Add(firstCardPlayer);

                }

                firstPlayer.RemoveAt(0);
                secondPlayer.RemoveAt(0);
            }

            if (firstPlayer.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }
        }
    }
}
