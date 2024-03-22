using System.Text;

namespace SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] commandWithArgs = Console.ReadLine().Split();
                int action = int.Parse(commandWithArgs[0]);

                if (action == 1)
                {
                    stack.Push(sb.ToString());
                    sb.Append(commandWithArgs[1]);
                }
                else if (action == 2)
                {
                    stack.Push(sb.ToString());
                    sb.Remove(sb.Length - int.Parse(commandWithArgs[1]), int.Parse(commandWithArgs[1]));
                }
                else if (action == 3)
                {
                    Console.WriteLine(sb[int.Parse(commandWithArgs[1]) - 1]);
                }
                else
                {
                    sb.Clear();
                    sb.Append(stack.Pop());
                }
            }
        }
    }
}