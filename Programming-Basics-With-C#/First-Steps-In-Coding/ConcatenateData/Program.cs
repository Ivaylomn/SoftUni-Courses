﻿using System;

namespace ConcatenateData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string lastName = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine($"You are {name} {lastName}, a {age}-years old person from {town}.");
        }
    }
}
