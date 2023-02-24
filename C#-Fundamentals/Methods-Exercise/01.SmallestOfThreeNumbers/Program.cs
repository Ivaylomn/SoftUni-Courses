namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            int smallNumber = GetSmalestNumber(numOne, numTwo, numThree);

            Console.WriteLine(smallNumber);
        }

        static int GetSmalestNumber(int one, int two, int three)
        {
            int smallNumber = Math.Min(Math.Min(one, two), three);

            return smallNumber;
        }
    }
}