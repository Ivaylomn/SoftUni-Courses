using System;

namespace _02Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfDAy = Console.ReadLine();

            string cloth = "";
            string shoes = "";

            if (degrees <= 18)
            {
                switch (timeOfDAy)
                {
                    case "Morning":
                        cloth = "Sweatshirt";
                        shoes = "Sneakers";
                        break;
                    case "Afternoon":
                    case "Evening":
                        cloth = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }
            else if (degrees > 18 && degrees <= 24)
            {
                switch (timeOfDAy)
                {
                    case "Morning":
                    case "Evening":
                        cloth = "Shirt";
                        shoes = "Moccasins";
                        break;
                    case "Afternoon":
                        cloth = "T-Shirt";
                        shoes = "Sandals";
                        break;
                }
            }
            else
            {
                switch (timeOfDAy)
                {
                    case "Morning":
                        cloth = "T-Shirt";
                        shoes = "Sandals";
                        break;
                    case "Afternoon":
                        cloth = "Swim Suit";
                        shoes = "Barefoot";
                        break;
                    case "Evening":
                        cloth = "Shirt";
                        shoes = "Moccasins";
                        break;
                }
            }

            Console.WriteLine($"It's {degrees} degrees, get your {cloth} and {shoes}.");
        } 

    }
}
