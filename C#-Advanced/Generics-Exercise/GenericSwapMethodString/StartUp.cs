using System;
using System.Linq;

namespace GenericSwapMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>(); ;
            while (n > 0)
            {
                box.Add(Console.ReadLine());
                n--;
            }

            int[] index = Console.ReadLine().Split().Select(int.Parse).ToArray();

            box.Swap(index[0], index[1]);

            Console.WriteLine(box.ToString());
        }
    }
}
