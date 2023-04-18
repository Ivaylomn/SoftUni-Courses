using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] currentCommand = command.Split();
                int elements = int.Parse(currentCommand[1]);

                switch (currentCommand[0])
                {
                    case "Delete":
                        wagons.RemoveAll(x => x == elements);
                        break;
                    case "Insert":
                        int index = int.Parse(currentCommand[2]);
                        wagons.Insert(index, elements);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
