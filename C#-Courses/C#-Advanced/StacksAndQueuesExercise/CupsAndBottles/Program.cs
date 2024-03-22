namespace CupsAndBottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int wastedLiters = 0;
            bool isNewOne = true;
            int currentCup = 0;

            while (cups.Any() && bottles.Any())
            {
                if (isNewOne)
                {
                    currentCup = cups.Peek();
                    isNewOne = false;
                }

                int currentBottles = bottles.Pop();

                if (currentCup - currentBottles <= 0)
                {
                    wastedLiters += currentCup - currentBottles;
                    cups.Dequeue();
                    isNewOne = true;
                }
                else
                {
                    currentCup -= currentBottles;
                }
            }

            if (cups.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }

            Console.WriteLine($"Wasted litters of water: {Math.Abs(wastedLiters)}");
        }
    }
}