using System.Text;

namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < words.Length; i++) 
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    sb.Append(words[i]);
                }
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
