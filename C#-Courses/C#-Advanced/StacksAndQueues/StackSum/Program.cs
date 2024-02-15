namespace StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack<int> numbersTwo = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();

            foreach (var number in numbers)
            {
                stack.Push(number);
            }

            string command = Console.ReadLine();
            while (command.ToLower() != "end")
            {
                string[] comArgs = command.Split();
                string action = comArgs[0].ToLower();

                if (action == "add")
                {
                    int numberOne = int.Parse(comArgs[1]);
                    int numberTwo = int.Parse(comArgs[2]);

                    stack.Push(numberOne);
                    stack.Push(numberTwo);
                }
                else if (action == "remove")
                {
                    int count = int.Parse(comArgs[1]);

                    if (stack.Count < count)
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        stack.Pop();
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Sum:" + " " + stack.Sum());
        }
    }
}