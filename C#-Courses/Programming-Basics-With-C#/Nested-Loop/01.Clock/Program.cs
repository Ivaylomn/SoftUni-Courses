using System;

namespace NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour < 24; hour++)
            {
                for (int minets = 0; minets < 60; minets++)
                {
                    Console.WriteLine($"{hour:d2}:{minets:d2}");
                }
            }
        }
    }
}
