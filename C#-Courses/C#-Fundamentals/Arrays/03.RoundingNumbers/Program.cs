using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = 0;
                }

                int rounded = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);

                Console.WriteLine($"{arr[i]} => {rounded}");
            }
        }
    }
}
