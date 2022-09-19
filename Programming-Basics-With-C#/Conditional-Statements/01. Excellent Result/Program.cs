using System;

namespace _01._Excellent_Result
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());

            if (value >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
