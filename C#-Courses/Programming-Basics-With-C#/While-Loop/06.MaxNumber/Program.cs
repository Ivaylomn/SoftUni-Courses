using System;

namespace _06MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int minNum = int.MaxValue;
            while (text != "Stop")
            {
                int number = int.Parse(text);

                if (number < minNum)
                {
                    minNum = number;
                }

                text = Console.ReadLine();
            }

            Console.WriteLine(minNum);
        }
    }
}
