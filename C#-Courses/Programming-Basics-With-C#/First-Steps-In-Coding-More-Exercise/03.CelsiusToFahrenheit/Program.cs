namespace _03.CelsiusToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celzium = double.Parse(Console.ReadLine());

            Console.WriteLine($"{celzium * 1.8 + 32:F2}");
        }
    }
}