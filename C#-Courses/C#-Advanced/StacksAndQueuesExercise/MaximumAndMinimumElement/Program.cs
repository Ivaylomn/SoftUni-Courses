namespace MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> queue = new Stack<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (numbers[0] == 1)
                {
                    queue.Push(numbers[1]);
                }
                else if (numbers[0] == 2)
                {
                    if (queue.Count > 0)
                    {
                        queue.Pop();
                    }
                }
                else if (numbers[0] == 3)
                {
                    if (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Max());
                    }
                }
                else
                {
                    if (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}