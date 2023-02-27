using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsNumber = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();
            for (int i = 0; i < commandsNumber; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();

                switch (command[2])
                {
                    case "not":
                        if (guests.Contains(command[0]))
                        {
                            guests.Remove(command[0]);
                        }
                        else
                        {
                            Console.WriteLine($"{command[0]} is not in the list!");
                        }
                        break;

                    default:
                        if (guests.Contains(command[0]))
                        {
                            Console.WriteLine($"{command[0]} is already in the list!");
                        }
                        else
                        {
                            guests.Add(command[0]);
                        }
                        break;
                }
            }

            foreach (var name in guests)
            {
                Console.WriteLine(name);
            }
        }
    }
}
