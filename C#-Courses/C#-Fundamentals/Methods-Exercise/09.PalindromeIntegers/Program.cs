using System;
namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (text != "End")
            {
                Console.WriteLine(IsPalidrom(text));

                text = Console.ReadLine();
            }

        }

        private static bool IsPalidrom(string text)
        {
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] == text[text.Length - 1 - i])
                {
                    return true;
                }
            }

            return false;
        }
    }
}