using System;

namespace _03SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double sum = 0;
            while (number > sum)
            {
                double numberTwo = int.Parse(Console.ReadLine());

                sum += numberTwo;
            }

            Console.WriteLine(sum);
        }
    }
}
