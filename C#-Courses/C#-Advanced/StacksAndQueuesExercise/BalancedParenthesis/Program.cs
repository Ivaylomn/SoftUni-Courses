namespace BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> parentheses = new Stack<char>();
            bool isBalanced = true;

            foreach (var item in input)
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    parentheses.Push(item);
                }
                else
                {
                    if (parentheses.Count <= 0)
                    {
                        isBalanced = false;
                        break;
                    }

                    if (item == ')' && parentheses.Peek() == '(')
                    {
                        parentheses.Pop();
                    }
                    else if (item == '}' && parentheses.Peek() == '{')
                    {
                        parentheses.Pop();
                    }
                    else if (item == ']' && parentheses.Peek() == '[')
                    {
                        parentheses.Pop();
                    }
                    else
                    {
                        isBalanced = false;
                    }

                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}