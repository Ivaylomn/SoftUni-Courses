namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int vowelsCount = GetVowelsCharCount(text);

            Console.WriteLine(vowelsCount);
        }

        private static int GetVowelsCharCount(string text)
        {
            text = text.ToLower();

            int counter = 0;
            foreach (char leter in text)
            {
                //A, E, I, O, U
                if (leter == 'a' || leter == 'e' || leter == 'i' || leter == 'o' || leter == 'u')
                {
                    counter++;
                }

            }

            return counter;
        }
    }
}