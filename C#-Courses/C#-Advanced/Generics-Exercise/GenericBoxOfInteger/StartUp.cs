using System;

namespace GenericBoxOfInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));

                Console.WriteLine(box.ToString());
                n--;
            }
        }
    }
}
