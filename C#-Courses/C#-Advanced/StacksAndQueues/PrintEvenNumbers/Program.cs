namespace PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    queue.Enqueue(num);
                }
            }

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}