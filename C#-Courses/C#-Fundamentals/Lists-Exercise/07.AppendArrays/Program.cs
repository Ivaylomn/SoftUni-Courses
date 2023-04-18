using System;
using System.Collections.Generic;

namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine().Split('|');

            List<string> rezult = new List<string>();

            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                string[] elements = arrays[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                rezult.AddRange(elements);
            }

            Console.WriteLine(string.Join(" ", rezult));
        }
    }
}
