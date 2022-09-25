using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            double number = 0;
            double minNumber = double.MaxValue;
            while (text != "Stop")
            {
                number = double.Parse(text);

                if (number < minNumber)
                {
                    minNumber = number;
                }

                text = Console.ReadLine();
            }

            Console.WriteLine(minNumber);
        }
    }
}
