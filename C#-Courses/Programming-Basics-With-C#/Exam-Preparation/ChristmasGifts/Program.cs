using System;

namespace PBExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int adult = 0;
            int kids = 0;
            int moneyToys = 0;
            int moneySwet = 0;

            while (command != "Christmas")
            {
                int years = int.Parse(command);

                if (years < 17)
                {
                    kids += 1;
                    moneyToys = 5;
                }
                if (years > 16 && years <= 130)
                {
                    adult += 1;
                    moneySwet = 15;
                }

                command = Console.ReadLine();
            }

            int total_money_toys = moneyToys * kids;
            int total_money_swet = moneySwet * adult;

            if (command == "Christmas")
            {
                Console.WriteLine($"Number of adults: {adult}");
                Console.WriteLine($"Number of kids: {kids}");
                Console.WriteLine($"Money for toys: {total_money_toys}");
                Console.WriteLine($"Money for sweaters: {total_money_swet}");
            }
        }
    }
}
