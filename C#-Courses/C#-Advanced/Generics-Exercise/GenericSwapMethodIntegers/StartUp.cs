using System;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>(); ;
            while (n > 0)
            {
                box.Add(int.Parse(Console.ReadLine()));
                n--;
            }

            int[] index = Console.ReadLine().Split().Select(int.Parse).ToArray();

            box.Swap(index[0], index[1]);

            Console.WriteLine(box.ToString());
        }
    }
}
