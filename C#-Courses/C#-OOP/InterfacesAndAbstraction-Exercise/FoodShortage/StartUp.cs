using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            List<Rebel> rebels = new List<Rebel>();
            List<Citizen> citizens = new List<Citizen>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length == 4)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    string birthday = input[3];

                    Citizen citizen = new Citizen(name, age, id, birthday);
                    citizens.Add(citizen);
                }
                else if (input.Length == 3)
                {
                    Rebel rebel = new Rebel(input[0], int.Parse(input[1]), input[2]);
                    rebels.Add(rebel);
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                Rebel currentRebel = rebels.FirstOrDefault(r => r.Name == command);
                Citizen currentCitizen = citizens.FirstOrDefault(c => c.Name == command);

                if (currentRebel != null)
                {
                    currentRebel.BuyFood();
                }

                if (currentCitizen != null)
                {
                    currentCitizen.BuyFood();
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(rebels.Sum(r => r.Food) + citizens.Sum(c => c.Food));
        }
    }
}
