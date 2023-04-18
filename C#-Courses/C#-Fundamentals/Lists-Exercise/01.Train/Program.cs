using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] curentCommand = command.Split();

                if (curentCommand[0] == "Add")
                {
                    wagons.Add(int.Parse(curentCommand[1]));
                }
                else
                {
                    int passangers = int.Parse(curentCommand[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passangers <= maxCapacity)
                        {
                            wagons[i] += passangers;
                            break;
                        }

                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
