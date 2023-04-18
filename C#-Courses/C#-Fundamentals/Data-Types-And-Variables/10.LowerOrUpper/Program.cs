using System;

namespace _10.LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());

            if (char.IsLower(one))
            {
                Console.WriteLine("lower-case");
            }
            else if (char.IsUpper(one))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
