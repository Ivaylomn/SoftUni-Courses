using System;

namespace _05._Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            double hall = double.Parse(Console.ReadLine());

            double cakePrice = hall * 0.20 ;
            double drinkPrice = cakePrice - cakePrice * 0.45;
            double animatorPrice = hall  / 3;

            double totalSum = cakePrice + drinkPrice + animatorPrice + hall;

            Console.WriteLine(totalSum);
        }
    }
}
