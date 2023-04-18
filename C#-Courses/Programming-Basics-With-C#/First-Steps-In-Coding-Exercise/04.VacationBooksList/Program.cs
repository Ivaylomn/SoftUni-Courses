using System;

namespace _04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            double pages = double.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());

            double readingTime = numberOfPages / pages;
            double totalTime = readingTime / numberOfDays;
           
            Console.WriteLine(totalTime);
        }
    }
}
