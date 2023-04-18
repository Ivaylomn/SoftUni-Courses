using System;

namespace _10.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int result = num * i;

                Console.WriteLine($"{num} X {i} = {result}");
            }
        }
    }
}
