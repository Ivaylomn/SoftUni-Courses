namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();

            int findIndex = text.IndexOf(pattern);

            while (findIndex != -1) 
            {
                text = text.Remove(findIndex, pattern.Length);
                findIndex = text.IndexOf(pattern);
            }

            Console.WriteLine(text);
        }
    }
}
