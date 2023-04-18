namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(text, repeat));
        }

        static string RepeatString(string text, int count)
        {
            string rezult = string.Empty;

            for (int i = 0; i < count; i++)
            {
                rezult += text;
            }

            return rezult;
        }
    }
}