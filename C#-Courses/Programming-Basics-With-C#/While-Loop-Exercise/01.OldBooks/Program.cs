using System;

namespace WhileLoopExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string books = Console.ReadLine();

            int counter = 1;
            while (books != "No More Books")
            {
                string booksSearch = Console.ReadLine();

                if (booksSearch == books)
                {
                    Console.WriteLine($"You checked {counter - 1} books and found it.");
                    return;
                }
                else if (booksSearch == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter - 1} books.");
                    break;
                }

                counter++;
            }
        }
    }
}
