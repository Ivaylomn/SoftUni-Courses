namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double firstFactorial = GetFactorialSum(firstNumber);
            double secondFactorial = GetFactorialSum(secondNumber);

            double rezult = firstFactorial / secondFactorial;

            Console.WriteLine($"{rezult:f2}");
        }

        private static double GetFactorialSum(int number)
        {
            double factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}