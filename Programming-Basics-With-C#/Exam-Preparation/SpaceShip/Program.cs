using System;

namespace SpaceShip
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double averageHeightAstronauts = double.Parse(Console.ReadLine());

            double rocket = width * lenght * height;
            double rooms = (averageHeightAstronauts + 0.4) * 2 * 2;
            double availableRooms = Math.Floor(rocket / rooms);

            if (availableRooms > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else if (availableRooms >= 3 && availableRooms <= 10)
            {
                Console.WriteLine($"The spacecraft holds {availableRooms} astronauts.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too small.");
            }
        }
    }
}
