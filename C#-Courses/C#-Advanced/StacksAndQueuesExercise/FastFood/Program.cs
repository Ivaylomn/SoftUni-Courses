namespace FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                if (foodQuantity < orders.Peek())
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    break;
                }

                foodQuantity -= orders.Dequeue();
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}