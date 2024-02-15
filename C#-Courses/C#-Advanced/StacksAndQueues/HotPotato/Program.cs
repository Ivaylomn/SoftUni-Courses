namespace HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kidsName = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            Queue<string> kids = new Queue<string>(kidsName);

            //Other way to fill the queue!
            //foreach (var item in kidsName)
            //{
            //    kids.Enqueue(item);
            //}

            while (kids.Count > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    kids.Enqueue(kids.Dequeue());
                }

                Console.WriteLine($"Removed {kids.Dequeue()}");
            }

            Console.WriteLine($"Last is {kids.Peek()}");
        }
    }
}