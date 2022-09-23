using System;

namespace _06._Salary1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            double fines = 0;
            for (int i = 0; i < numberOfTabs; i++)
            {
                string website = Console.ReadLine();

                switch (website)
                {
                    case "Faebook":
                        fines += 150;
                        break;
                    case "Instagram":
                        fines += 100;
                        break;
                    case "Reddit":
                        fines += 50;
                        break;
                }

                if (fines >= salary)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (fines < salary)
            {
                Console.WriteLine(salary - fines);
            }
        }
    }
}
