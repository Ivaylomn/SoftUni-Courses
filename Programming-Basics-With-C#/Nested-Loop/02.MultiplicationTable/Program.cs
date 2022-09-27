using System;

namespace _02MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int numOne = 1; numOne <= 10; numOne++)
            {
                for (int numTwo = 1; numTwo <= 10; numTwo++)
                {
                    Console.WriteLine($"{numOne} * {numTwo} = {numOne * numTwo}");
                }
            }
        }
    }
}
