using System;

namespace MyExamProgrammingBasick
{
    class Program
    {
        static void Main(string[] args)
        {
            int videoCardPrice = int.Parse(Console.ReadLine());
            int adapterPrice = int.Parse(Console.ReadLine());
            double consumedElectriciPiceForDayOfCard = double.Parse(Console.ReadLine());
            double incomePerOnaCardOfDay = double.Parse(Console.ReadLine());

            int totalPriceCard = videoCardPrice * 13;
            int totalPriceAdapter = adapterPrice * 13;
            int totalMoneySpent = totalPriceCard + totalPriceAdapter + 1000;
            double totalPricePerCardForDay = incomePerOnaCardOfDay - consumedElectriciPiceForDayOfCard;
            double totalMoneyForCard = 13 * totalPricePerCardForDay;
            double daysReturn = totalMoneySpent / totalMoneyForCard;

            Console.WriteLine(totalMoneySpent);
            Console.WriteLine(Math.Ceiling(daysReturn));
        }
    }
}
