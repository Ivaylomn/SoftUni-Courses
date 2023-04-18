using System;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine()) * 100;
            double widtht = double.Parse(Console.ReadLine()) * 100;

            double cols = Math.Truncate((widtht - 100) / 70);
            double rows = Math.Truncate(lenght / 120);
            double seads = cols * rows - 3;

            Console.WriteLine(seads);
        }
    }
}
