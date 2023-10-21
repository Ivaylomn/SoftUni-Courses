namespace _04.PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                PrintLine(i);
            }
            for (int i = number - 1; i > 0; i--)
            {
                PrintLine(i);
            }
        }

        static void PrintLine(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}