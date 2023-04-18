using System;

namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            string[] arrTwo = Console.ReadLine().Split();

            for (int i = 0; i < arrTwo.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arrTwo[i] == arr[j])
                    {
                        Console.Write(arrTwo[i] + " ");
                    }
                }
            }
        }
    }
}
