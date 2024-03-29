﻿using System.Collections;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split().Reverse().ToArray();
            Stack<string> stack = new Stack<string>();

            foreach (var item in text)
            {
                stack.Push(item);
            }

            while (stack.Count > 1)
            {
                int numberA = int.Parse(stack.Pop());
                string @operator = stack.Pop();
                int numberB = int.Parse(stack.Pop());

                if (@operator == "+")
                {
                    int result = numberA + numberB;
                    stack.Push(result.ToString());
                }
                else if (@operator == "-")
                {
                    int result = numberA - numberB;
                    stack.Push(result.ToString());
                }
            }

            Console.WriteLine(stack.Peek());
        }
    }
}