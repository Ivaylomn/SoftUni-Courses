using System;

namespace _04Sequence2k1
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int counter = 1;
            while (counter <= number)
            {
                Console.WriteLine(counter);

                counter = counter * 2 + 1;
            }
        }
    }
}
