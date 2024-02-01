using System;
using System.Numerics;

namespace _02.BigFactorial
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }

        public void Bay()
        {
            Console.WriteLine("Bay" + Name);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;

            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
