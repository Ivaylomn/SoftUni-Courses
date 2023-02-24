namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int subtract = Subtract(Sum(firstNumber, secondNumber), thirdNumber);

            Console.WriteLine(subtract);
        }

        private static int Subtract(int v, int thirdNumber)
        {
            return v - thirdNumber;
        }

        private static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}