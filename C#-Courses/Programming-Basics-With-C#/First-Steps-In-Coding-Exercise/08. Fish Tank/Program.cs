using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtInCm = int.Parse(Console.ReadLine());
            int widthInCm = int.Parse(Console.ReadLine());
            int heighInCm = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double aquariumVolume = lenghtInCm * widthInCm * heighInCm;
            double totalLiters = aquariumVolume * 0.01;
            double precentInLiters = percentage * totalLiters;
            double totalSum = totalLiters * (1 - precentInLiters);

            Console.WriteLine(totalSum);
        }
    }
}
