using System;

namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            int result = 0;
            for (int i = numTwo; i <= 10; i++)
            {
                result = numOne * i;

                Console.WriteLine($"{numOne} X {i} = {result}");
            }

            if (numTwo > 10)
            {
                result = numOne * numTwo;

                Console.WriteLine($"{numOne} X {numTwo} = {result}");
            }
        }
    }
}
