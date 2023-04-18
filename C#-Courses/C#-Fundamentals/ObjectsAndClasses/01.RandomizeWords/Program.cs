using System;

namespace _01.RandomizeWords
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }

        public void Bay()
        {
            Console.WriteLine("Bay" + Name);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            Random rnd = new Random();

            for (int i = 0; i < text.Length; i++)
            {
                int index = rnd.Next(text.Length);
                string temp = text[i];
                text[i] = text[index];
                text[index] = temp;
            }

            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
        }
    }
}
