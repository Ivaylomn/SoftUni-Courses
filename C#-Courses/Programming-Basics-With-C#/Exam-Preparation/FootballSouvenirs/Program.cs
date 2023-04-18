using System;

namespace FootballSouvenirs
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenir = Console.ReadLine();
            int sumSouvenirs = int.Parse(Console.ReadLine());

            double price = 0.0;
            if (team == "Argentina")
            {
                if (souvenir == "flags")
                {
                    price = 3.25 * sumSouvenirs;
                }
                else if (souvenir == "caps")
                {
                    price = 7.2 * sumSouvenirs;
                }
                else if (souvenir == "posters")
                {
                    price = 5.1 * sumSouvenirs;
                }
                else if (souvenir == "stickers")
                {
                    price = 1.25 * sumSouvenirs;
                }
            }
            else if (team == "Brazil")
            {
                if (souvenir == "flags")
                {
                    price = 4.20 * sumSouvenirs;
                }
                else if (souvenir == "caps")
                {
                    price = 8.50 * sumSouvenirs;
                }
                else if (souvenir == "posters")
                {
                    price = 5.35 * sumSouvenirs;
                }
                else if (souvenir == "stickers")
                {
                    price = 1.20 * sumSouvenirs;
                }
            }
            else if (team == "Croatia")
            {
                if (souvenir == "flags")
                {
                    price = 2.75 * sumSouvenirs;
                }
                else if (souvenir == "caps")
                {
                    price = 6.9 * sumSouvenirs;
                }
                else if (souvenir == "posters")
                {
                    price = 4.95 * sumSouvenirs;
                }
                else if (souvenir == "stickers")
                {
                    price = 1.1 * sumSouvenirs;
                }
            }
            else if (team == "Denmark")
            {
                if (souvenir == "flags")
                {
                    price = 3.10 * sumSouvenirs;
                }
                else if (souvenir == "caps")
                {
                    price = 6.50 * sumSouvenirs;
                }
                else if (souvenir == "posters")
                {
                    price = 4.80 * sumSouvenirs;
                }
                else if (souvenir == "stickers")
                {
                    price = 0.9 * sumSouvenirs;
                }
            }

            if (team == "Argentina" || team == "Brazil" || team == "Croatia" || team == "Denmark")
            {
                if (souvenir == "flags" || souvenir == "caps" || souvenir == "posters" || souvenir == "stickers")
                {
                    Console.WriteLine($"Pepi bought {sumSouvenirs} {souvenir} of {team} for {price:f2} lv.");
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                }
            }
            else if (team != "Argentina" || team != "Brazil" || team != "Croatia" || team != "Denmark")
            {
                Console.WriteLine("Invalid country!");
            }
            else
            {
                Console.WriteLine("Invalid stock!");
            }
        }
    }
}
