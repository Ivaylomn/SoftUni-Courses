using System;

namespace _11RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal length = decimal.Parse(Console.ReadLine());
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());

            decimal volume = (length * width * height) / 3;
            Console.Write($"Length: Width: Height: Pyramid Volume: {volume:f2}");
        }
    }
}
