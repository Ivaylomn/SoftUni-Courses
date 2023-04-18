namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculatesArea(width, height));
        }

        static int CalculatesArea(int width, int height)
        {
            return width * height;
        }
    }
}