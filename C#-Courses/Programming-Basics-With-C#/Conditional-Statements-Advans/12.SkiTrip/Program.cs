using System;

namespace _11SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysStay = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();

            daysStay -= 1;
            double pricePerNight = 0;
            double discount = 0;
            double totalSum = 0;

            switch (room)
            {
                case "room for one person":
                    pricePerNight = 18.00;
                    totalSum = daysStay * pricePerNight;
                    discount = totalSum;
                    break;
                case "apartment":
                    pricePerNight = 25.00;
                    if (daysStay < 10)
                    {
                        totalSum = daysStay * pricePerNight;
                        discount = totalSum - totalSum * 30 / 100;
                        totalSum = discount;
                    }
                    else if (daysStay >= 10 && daysStay <= 15)
                    {
                        totalSum = daysStay * pricePerNight;
                        discount = totalSum - totalSum * 35 / 100;
                        totalSum = discount;
                    }
                    else
                    {
                        totalSum = daysStay * pricePerNight;
                        discount = totalSum - totalSum * 50 / 100;
                        totalSum = discount;
                    }
                    break;
                case "president apartment":
                    pricePerNight = 35.00;
                    if (daysStay < 10)
                    {
                        totalSum = daysStay * pricePerNight;
                        discount = totalSum - totalSum * 10 / 100;
                        totalSum = discount;
                    }
                    else if (daysStay >= 10 && daysStay <= 15)
                    {
                        totalSum = daysStay * pricePerNight;
                        discount = totalSum - totalSum * 15 / 100;
                        totalSum = discount;
                    }
                    else
                    {
                        totalSum = daysStay * pricePerNight;
                        discount = totalSum - totalSum * 20 / 100;
                        totalSum = discount;
                    }
                    break;
                default:
                    break;
        
            }
            if (rating == "positive")
            {
                totalSum += discount * 25 / 100;
            }
            else
            {
                totalSum -= discount * 10 / 100;
            }

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
