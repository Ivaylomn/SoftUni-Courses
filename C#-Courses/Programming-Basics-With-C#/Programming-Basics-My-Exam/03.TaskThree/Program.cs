using System;

namespace _03Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string catBreed = Console.ReadLine();
            string sex = Console.ReadLine();
            double age = 0;

            switch (catBreed)
            {
                case "British Shorthair":
                    if (sex == "m")
                    {
                        age = 13;
                    }
                    else
                    {
                        age = 14;
                    }
                    break;
                case "Siamese":
                    if (sex == "m")
                    {
                        age = 15;
                    }
                    else
                    {
                        age = 16;
                    }
                    break;
                case "Persian":
                    if (sex == "m")
                    {
                        age = 14;
                    }
                    else
                    {
                        age = 15;
                    }
                    break;
                case "Ragdoll":
                    if (sex == "m")
                    {
                        age = 16;
                    }
                    else
                    {
                        age = 17;
                    }
                    break;
                case "American Shorthair":
                    if (sex == "m")
                    {
                        age = 12;
                    }
                    else
                    {
                        age = 13;
                    }
                    break;
                case "Siberian":
                    if (sex == "m")
                    {
                        age = 11;
                    }
                    else
                    {
                        age = 12;
                    }
                    break;
                default:
                    Console.WriteLine($"{catBreed} is invalid cat!");
                    return;
                    
            }

            double catMounts = age * 12;
            Console.WriteLine($"{Math.Floor(catMounts / 6)} cat months");
        }
    }
}
