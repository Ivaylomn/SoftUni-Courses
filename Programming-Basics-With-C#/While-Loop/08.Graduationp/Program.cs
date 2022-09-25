using System;

namespace _08GraduationpPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int classCount = 1;
            double sum = 0.0;
            while (classCount <= 12)
            {
                double currentGrade = double.Parse(Console.ReadLine());

                if (currentGrade >= 4)
                {
                    classCount++;
                    sum = sum + currentGrade;
                }
                else if (currentGrade == 2)
                {
                    Console.WriteLine($"{name} has been excluded at {classCount} grade");
                    return;
                }
            }

            Console.WriteLine($"{name} graduated. Average grade: {sum / 12:f2}");
        }
    }
}
