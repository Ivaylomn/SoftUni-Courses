namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string middle = GetMiddle(text);

            Console.WriteLine(middle);
        }

        private static string GetMiddle(string text)
        {
            if (text.Length % 2 == 0)
            {
                return $"{text[text.Length / 2 - 1]}{text[text.Length / 2]}";
            }

            return $"{text[(text.Length - 1) / 2]}";
        }
    }
}