using System;

namespace _02Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();

            string wrongPassword = "";
            int counter = 0;
            while (wrongPassword != password)
            {
                if (counter == 3)
                {
                    Console.WriteLine("Yuo submit wrong password!");
                }

                wrongPassword = Console.ReadLine();

                counter++;
            }

            Console.WriteLine($"Welcome {name}!");

        }
    }
}
