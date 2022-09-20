using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            double rezult = 0;


            if (operation == "+")
            {
                rezult = numberOne + numberTwo;
                if (rezult % 2 == 0)
                {
                    Console.WriteLine($"{numberOne} + {numberTwo} = {rezult} - even");
                }
                else
                {
                    Console.WriteLine($"{numberOne} + {numberTwo} = {rezult} - odd");
                }

            }
            else if (operation == "-")
            {
                rezult = numberOne - numberTwo;
                if (rezult % 2 == 0)
                {
                    Console.WriteLine($"{numberOne} - {numberTwo} = {rezult} - even");
                }
                else
                {
                    Console.WriteLine($"{numberOne} - {numberTwo} = {rezult} - odd");
                }


            }
            else if (operation == "*")
            {
                rezult = numberOne * numberTwo;
                if (rezult % 2 == 0)
                {
                    Console.WriteLine($"{numberOne} * {numberTwo} = {rezult} - even");
                }
                else
                {
                    Console.WriteLine($"{numberOne} * {numberTwo} = {rezult} - odd");
                }


            }
            else if (operation == "/")
            {
                
                if (numberOne == 0 || numberTwo == 0)
                {
                    Console.WriteLine($"Cannot divide {numberOne} by zero");
                }
                else
                {
                    rezult = numberOne * 1.00 / numberTwo;
                    Console.WriteLine($"{numberOne} / {numberTwo} = {rezult:f2}");
                }
            }
            else if (operation == "%")
            {
               
                if (numberOne == 0 || numberTwo == 0)
                {
                    Console.WriteLine($"Cannot divide {numberOne} by zero");
                }
                else
                {
                    rezult = numberOne % numberTwo;
                    Console.WriteLine($"{numberOne} % {numberTwo} = {rezult}");
                }

            }



        }
    }
}
