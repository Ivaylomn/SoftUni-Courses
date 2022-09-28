using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceToSkumriqlPerKg = double.Parse(Console.ReadLine());
            double priceToCacaPerKg = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            int midiKg = int.Parse(Console.ReadLine());

            double pricePalamid = priceToSkumriqlPerKg + priceToSkumriqlPerKg * 0.60;
            double priceSafrid = priceToCacaPerKg + priceToCacaPerKg * 0.80;
            double sum = (palamudKg * pricePalamid) + (safridKg * priceSafrid) + (midiKg * 7.50);

            Console.WriteLine($"{sum:f2}");
        }
    }
}
