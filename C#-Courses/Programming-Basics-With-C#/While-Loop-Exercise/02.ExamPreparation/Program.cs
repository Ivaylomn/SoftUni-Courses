using System;

namespace _02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradeLeft = int.Parse(Console.ReadLine());

            double avaregeGrade = 0;
            double counter = 0;
            double sum = 0;
            while (true)
            {
                string task = Console.ReadLine();

                if (task == "Enough")
                {
                    avaregeGrade = sum / counter;

                    Console.WriteLine($"Average score: {avaregeGrade:f2}");
                    Console.WriteLine($"Number of problems: {counter}");
                    Console.WriteLine($"Last problem: {task}");

                    return;
                }
                else if (gradeLeft <= 4)
                {
                    Console.WriteLine($"You need a break, {counter:F2} poor grades.");
                    return;
                }

                int grade = int.Parse(Console.ReadLine());

                counter++;
                sum = sum + grade;
            }
        }
    }
}
