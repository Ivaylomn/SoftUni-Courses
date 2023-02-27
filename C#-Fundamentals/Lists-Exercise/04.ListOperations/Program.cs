using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string operation = Console.ReadLine();

            while (operation != "End")
            {
                string[] commandArgs = operation.Split();
                string action = commandArgs[0];

                if (action == "Add")
                {
                    int number = int.Parse(commandArgs[1]);
                    numbers.Add(number);
                }
                else if (action == "Insert")
                {
                    int number = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        operation = Console.ReadLine();
                        continue;
                    }

                    numbers.Insert(index, number);
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(commandArgs[1]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        operation = Console.ReadLine();
                        continue;
                    }

                    numbers.RemoveAt(index);

                }
                else if (commandArgs[1] == "left")
                {
                    int count = int.Parse(commandArgs[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int firstElemnt = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(firstElemnt);

                    }

                }
                else if (commandArgs[1] == "right")
                {
                    int count = int.Parse(commandArgs[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int lastElemnts = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, lastElemnts);
                    }

                }

                operation = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
