using System;

namespace _03.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int cake = height * width;
            int sum = 0;
            while (text != "STOP")
            {
                sum += int.Parse(text);

                if (sum > cake)
                {
                    Console.WriteLine($"No more cake left! You need {sum - cake} pieces more.");
                    return;
                }

                text = Console.ReadLine();
            }

            Console.WriteLine($"{cake - sum} pieces are left.");
        }
    }
}
