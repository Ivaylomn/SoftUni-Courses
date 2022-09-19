using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int termOfTheDeposit = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());

            double depositPeriod = depositSum * interestRate / 100;
            double interest = depositPeriod / 12;
            double total = depositSum + (termOfTheDeposit * interest);

            Console.WriteLine(total);



        }
    }
}
