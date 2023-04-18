using System;

namespace _04SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = start; i <= finish; i++)
            {
                for (int k = start; k <= finish; k++)
                {
                    int rezult = i + k;

                    counter++;
                    if (rezult == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {k} = {magicNum})");

                        return;
                    }

                }
            }

            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
        }
    }
}
