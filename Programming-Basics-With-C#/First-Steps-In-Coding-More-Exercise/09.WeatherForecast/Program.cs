namespace _09.WeatherForecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string water = Console.ReadLine();

            if (water == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}