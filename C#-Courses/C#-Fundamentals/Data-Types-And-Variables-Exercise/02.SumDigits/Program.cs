namespace _02.SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            while (number > 0)
            {
                int lastDigits = number % 10;
                sum += lastDigits;

                number /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}