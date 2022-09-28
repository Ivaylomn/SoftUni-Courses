using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double wall = x * y;
            double window = 1.5 * 1.5;
            double twoWall = 2 * wall - 2 * window;
            double backWall = x * x;
            double entrice = 1.2 * 2;
            double total = 2 * backWall - entrice;
            double totalArea = twoWall + total;
            double greenPaint = totalArea / 3.4;
            double roof = 2 * (x * y);
            double twoTriangle = 2 * (x * h / 2);
            double totalTwo = roof + twoTriangle;
            double redPaint = totalTwo / 4.3;

            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");
        }
    }
}
