using System;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }

            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            Console.WriteLine(sum);
        }
    }
}
