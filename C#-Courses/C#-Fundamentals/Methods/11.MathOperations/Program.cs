namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            double rezult = Math.Round(Calculation(number, operation, numberTwo), 2);

            Console.WriteLine(rezult);
        }
        static double Calculation(int a, char oper, int b)
        {
            double rezult = 0;
            switch (oper)
            {
                case '/':
                    rezult = a / b;
                    break;
                case '*':
                    rezult = a * b;
                    break;
                case '+':
                    rezult = a + b;
                    break;
                case '-':
                    rezult = a - b;
                    break;

            }

            return rezult;
        }
    }
}