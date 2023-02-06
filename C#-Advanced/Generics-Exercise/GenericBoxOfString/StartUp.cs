using System;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box box = new Box();

            while (n > 0)
            {
                string value = Console.ReadLine();
                
                box.Add(value);
                n--;
            }

            Console.WriteLine(box.ToString());
        }
    }
}
