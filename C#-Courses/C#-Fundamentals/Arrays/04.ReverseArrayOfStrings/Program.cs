using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            // The shorter option for solution this task.
            Console.WriteLine(string.Join(' ', text.Reverse()));

            //And solution with FOR loop 
            for (int i = 0; i < text.Length / 2; i++)
            {
                var oldElements = text[i];
                text[i] = text[text.Length - 1 - i];
                text[text.Length - 1 - i] = oldElements;
            }

            Console.WriteLine(string.Join(' ', text));
        }
    }
}
