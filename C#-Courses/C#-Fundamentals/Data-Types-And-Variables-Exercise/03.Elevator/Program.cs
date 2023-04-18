namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double result = (double)people / capacity;

            Console.WriteLine(Math.Ceiling(result));
        }
    }
}