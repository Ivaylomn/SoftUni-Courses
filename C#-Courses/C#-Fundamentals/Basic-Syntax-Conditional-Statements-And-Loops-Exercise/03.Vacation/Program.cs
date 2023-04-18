using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double discount = 0;
            double totalPrice = 0;
            switch (group)
            {
                case "Students":

                    switch (day)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;

                    }
                    totalPrice = count * price;
                    if (count >= 30)
                    {
                        discount = totalPrice * 0.15;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16.00;
                            break;
                    }
                    totalPrice = count * price;
                    if (count >= 100)
                    {
                        count -= 10;
                        totalPrice = count * price;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = 15.00;
                            break;
                        case "Saturday":
                            price = 20.00;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                    totalPrice = count * price;
                    if (count >= 10 && count <= 20)
                    {
                        discount = totalPrice * 0.05;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {totalPrice - discount:F2}");
        }
    }
}
