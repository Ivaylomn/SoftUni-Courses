using System;

namespace DateTypeAndVaribles
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            Console.WriteLine($"{(decimal)meters / 1000:F2}");
        }
    }
}
