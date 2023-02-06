using System;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            while (n > 0)
            {
                
                
                box.Add(Console.ReadLine());
                n--;
            }

            Console.WriteLine(box.ToString());
        }
    }
}
