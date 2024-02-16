using System.Linq;
using System.Text;

namespace SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split(", "));

            string command = Console.ReadLine();
            while (queue.Count > 0)
            {
                string[] commArgs = command.Split();
                string action = commArgs[0];

                if (action == "Play")
                {
                    queue.Dequeue();
                }
                else if (action == "Add")
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    for (int i = 1; i < commArgs.Length; i++)
                    {
                        stringBuilder.Append(commArgs[i] + " ");
                    }

                    string songName = stringBuilder.ToString().TrimEnd();
                    if (!queue.Contains(songName))
                    {
                        queue.Enqueue(songName);
                    }
                    else
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                }
                else if (action == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}