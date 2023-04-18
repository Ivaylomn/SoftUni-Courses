using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsCount = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());

            double price = (dogsCount * 2.50) + (otherAnimals * 4);

            Console.WriteLine($"{price} lv.");
        }
    }
}
