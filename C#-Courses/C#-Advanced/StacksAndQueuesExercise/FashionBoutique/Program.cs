namespace FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;
            while (stack.Count > 0)
            {
                if (stack.Peek() + sum <= capacity)
                {
                    sum += stack.Pop();
                }
                else
                {
                    sum = 0;
                    count++;
                }
            }

            Console.WriteLine(count + 1);
        }
    }
}