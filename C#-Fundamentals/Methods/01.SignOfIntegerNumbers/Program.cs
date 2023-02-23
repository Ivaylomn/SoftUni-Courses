namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIntegerNumber(int.Parse(Console.ReadLine()));
        }


        static void PrintIntegerNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is posititve.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
