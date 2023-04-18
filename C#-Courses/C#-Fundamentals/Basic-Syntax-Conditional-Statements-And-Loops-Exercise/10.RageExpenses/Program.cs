using System;

namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double money = headsetPrice * (lostGameCount / 2);
            money += mousePrice * (lostGameCount / 3);
            money += keyboardPrice * (lostGameCount / 6);
            money += displayPrice * (lostGameCount / 12);

            Console.WriteLine($"Rage expenses: {money:f2} lv.");
        }
    }
}
