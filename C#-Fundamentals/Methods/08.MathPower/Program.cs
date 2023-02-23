namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double rezult = MathPower(number, power);

            Console.WriteLine(rezult);
        }

        static double MathPower(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}