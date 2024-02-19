using System;
using System.Collections.Generic;

namespace _01.CountCharsinString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    continue;
                }
                if (dict.ContainsKey(text[i]))
                {
                    dict[text[i]]++;
                }
                else
                {
                    dict.Add(text[i], 1);
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
