using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());

            double totalMeters = meters * 7.61;
            double discount = totalMeters * 18 / 100;
            double finalPrice = totalMeters - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
