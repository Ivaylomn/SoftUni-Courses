using System;

namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amountMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double studentsDiscount = Math.Ceiling(studentsCount + studentsCount * 0.10);
            double everySixBeltsFree = studentsCount - studentsCount / 6;
            double total = lightsabersPrice * studentsDiscount + robesPrice * studentsCount + beltsPrice * everySixBeltsFree;

            if (total <= amountMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(amountMoney - total):f2}lv more.");
            }
        }
    }
}
