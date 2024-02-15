namespace BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            for (int i = 0; i < input[1]; i++)
            {
                stack.Pop();
            }

            bool isContains = true;
            if (stack.Contains(input[2]))
            {
                Console.WriteLine("true");
                isContains = false;
            }

            if (!stack.Contains(input[2]))
            {
                if (stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                    isContains = false;
                }
            }

            if (isContains)
            {
                Console.WriteLine(stack.Count());
            }
        }
    }
}