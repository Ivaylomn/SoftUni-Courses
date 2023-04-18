namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                Console.WriteLine(Add(numberOne, numberTwo));
            }
            else if (command == "subtract")
            {
                Console.WriteLine(Subtract(numberOne, numberTwo));
            }
            else if (command == "divide")
            {
                Console.WriteLine(Divide(numberOne, numberTwo));
            }
            else if (command == "multiply")
            {
                Console.WriteLine(Multiply(numberOne, numberTwo));
            }
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}