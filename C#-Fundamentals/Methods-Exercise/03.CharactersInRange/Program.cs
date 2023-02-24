namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            char start = firstChar;
            char end = secondChar;

            if (secondChar < firstChar)
            {
                start = secondChar;
                end = firstChar;
            }

            PrintCharacketrInRange(start, end);
        }

        private static void PrintCharacketrInRange(char start, char end)
        {
            for (char i = (char)(start + 1); i < end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}