using System;
using System.Linq;

namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                bool isTopIntiger = true;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int rightNumbers = arr[j];
                    if (rightNumbers >= currentNumber)
                    {
                        isTopIntiger = false;
                        break;
                    }
                }

                if (isTopIntiger)
                {
                    Console.Write(currentNumber + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
