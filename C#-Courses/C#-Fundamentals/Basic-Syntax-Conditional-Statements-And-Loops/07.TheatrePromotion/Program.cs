using System;

namespace _07.TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            double price = 0;
            switch (day)
            {
                case "Weekday":
                    if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                    {
                        price = 12;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 18;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    break;
                case "Weekend":
                    if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                    {
                        price = 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 20;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 12;
                    }
                    else if (age > 63 && age <= 122)
                    {
                        price = 10;
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                        return;
                    }
                    break;

            }

            Console.WriteLine($"{price}$");

        }
    }
}
