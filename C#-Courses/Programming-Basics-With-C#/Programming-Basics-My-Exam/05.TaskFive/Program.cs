using System;

namespace _05Taks
{
    class Program
    {
        static void Main(string[] args)
        {
            int buyQuantityFoodForDogInKilogram = int.Parse(Console.ReadLine()) * 1000;
            string gram = Console.ReadLine();

            int sum = 0;
            while (gram != "Adopted")
            {
                int food = int.Parse(gram);

                gram = Console.ReadLine();

                sum += food;
            }

            if (sum <= buyQuantityFoodForDogInKilogram)
            {
                int leftMoney = buyQuantityFoodForDogInKilogram - sum;
                Console.WriteLine($"Food is enough! Leftovers: {leftMoney} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {sum - buyQuantityFoodForDogInKilogram} grams more.");
            }
        }
    }
}
