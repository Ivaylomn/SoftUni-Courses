namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            TotalPrice(product, quantity);
        }
        static void TotalPrice(string a, int b)
        {
            double price = 0;

            if (a == "coffee")
            {
                price = 1.50;
            }
            else if (a == "coke")
            {
                price = 1.40;
            }
            else if (a == "water")
            {
                price = 1.00;
            }
            else if (a == "snacks")
            {
                price = 2.00;
            }

            double sum = price * b;

            Console.WriteLine($"{sum:f2}");
        }
    }
}