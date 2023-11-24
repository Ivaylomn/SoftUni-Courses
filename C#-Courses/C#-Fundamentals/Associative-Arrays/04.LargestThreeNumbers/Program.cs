namespace _04.LargestThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> sortedList = numbers.OrderByDescending(x => x).ToList();

            for (int i = 0; i < 3; i++) 
            {
                Console.Write(sortedList[i] + " ");
            }
        }
    }
}
