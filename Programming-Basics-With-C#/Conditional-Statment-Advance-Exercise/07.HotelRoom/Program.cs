using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string months = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());

            double priceForStudio = 0;
            double priceForApartment = 0;

            switch (months)
            {
                case "May":
                case "October":

                    double discount = 0;
                    priceForStudio = 50.00;
                    if (nightCount > 7 && nightCount <= 14)
                    {
                        discount = priceForStudio * 5 / 100;
                        priceForStudio = priceForStudio - discount;
                    }
                    else if (nightCount > 14)
                    {
                        discount = priceForStudio * 30 / 100;
                        priceForStudio = priceForStudio - discount;
                    }
                    priceForApartment = 65.00;
                    if (nightCount > 14)
                    {
                        discount = priceForApartment * 10 / 100;
                        priceForApartment = priceForApartment - discount;
                    }

                    break;
                case "June":
                case "September":
                    priceForStudio = 75.20;
                    if (nightCount > 14)
                    {
                        discount = priceForStudio * 20 / 100;
                        priceForStudio = priceForStudio - discount;
                    }
                    priceForApartment = 68.70;
                    if (nightCount > 14)
                    {
                        discount = priceForApartment * 10 / 100;
                        priceForApartment = priceForApartment - discount;
                    }
                    break;
                case "July":
                case "August":
                    priceForStudio = 76.00;
                    priceForApartment = 77.00;
                    if (nightCount > 14)
                    {
                        discount = priceForApartment * 10 / 100;
                        priceForApartment = priceForApartment - discount;
                    }
                    break;

            }

            double stayPriceToStudio = priceForStudio * nightCount;
            double stayPriceToApartment = priceForApartment * nightCount;

            Console.WriteLine($"Apartment: {stayPriceToApartment:f2} lv.");
            Console.WriteLine($"Studio: {stayPriceToStudio:f2} lv.");

    
        }
    }
}
