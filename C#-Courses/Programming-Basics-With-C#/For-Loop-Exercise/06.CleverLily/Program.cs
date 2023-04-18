using System;

namespace _11CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilyYear = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            double sum = 0;
            double toys = 0;
            double money = 0;

            for (int i = 1; i <= lilyYear; i++)
            {
                if (i % 2 == 0)
                {
                    money += 10;
                    sum += money - 1;
                    //money--;
                }
                else
                {
                    toys++;
                }
                
            }
            double totalMoney = (toys * toysPrice) + sum;

            if (totalMoney >= washingMachinePrice)
            {
                double leftMoney = totalMoney - washingMachinePrice;
                Console.WriteLine($"Yes! {leftMoney:F2}");
            }
            else
            {
                double neededMoney = washingMachinePrice - totalMoney;
                Console.WriteLine($"No! {neededMoney:f2}");
            }
        }
    }
}
