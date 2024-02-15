using System.Threading.Channels;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                if (command == "Paid")
                {
                    Console.WriteLine(string.Join("\n", queue));
                    queue.Clear();
                }
                else
                {
                    queue.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}