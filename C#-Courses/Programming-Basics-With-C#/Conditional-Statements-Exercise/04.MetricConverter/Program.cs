using System;

namespace _04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inPut = Console.ReadLine();
            string outPut = Console.ReadLine();

            if (inPut == "mm" && outPut == "m")
            {
                double meters = number / 1000;
                Console.WriteLine($"{meters:f3}");
            }
            else if (inPut == "mm" && outPut == "cm")
            {
                double centimeters = number / 10;
                Console.WriteLine($"{centimeters:F3}");
            }
            else if (inPut == "cm" && outPut == "m")
            {
                double meters = number / 100;
                Console.WriteLine($"{meters:F3}");
            }
            else if (inPut == "m" && outPut == "mm")
            {
                double milimeters = number * 1000;
                Console.WriteLine($"{milimeters:F3}");
            }
            else if (inPut == "m" && outPut == "cm")
            {
                double centimeters = number * 100;
                Console.WriteLine($"{centimeters:F3}");
            }
            else if (inPut == "cm" && outPut == "mm")
            {
                double milimeters = number * 10;
                Console.WriteLine($"{milimeters:F3}");
            }
        }
    }
}
