using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = (Console.ReadLine());

            if (figure == "square")
            {
                double lenght = double.Parse(Console.ReadLine());
                double area = lenght * lenght;
                Console.WriteLine("{0:f3}" , area);
            }
            else if (figure == "rectangle")
            {
                double leghtA = double.Parse(Console.ReadLine());
                double leghtB = double.Parse(Console.ReadLine());
                double area = leghtA * leghtB;
                Console.WriteLine("{0:f3}", area);
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * (radius * radius);
                Console.WriteLine("{0:f3}", area);
            }
            else if (figure == "triangle")
            {
                double leght = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = (leght * height) / 2;
                Console.WriteLine("{0:f3}", area);
            }
        }
    }
}
