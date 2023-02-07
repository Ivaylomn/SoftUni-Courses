using System;
using System.Linq;

namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();

            MyTuple<string, string, string> person = new MyTuple<string, string, string>($"{personInfo[0]} {personInfo[1]}", personInfo[2],string.Join(" ", personInfo.Skip(3)));

            string[] nameAndlittersBeer = Console.ReadLine().Split();
            bool IsDrunk = nameAndlittersBeer[2] == "drunk";
            MyTuple<string, int, bool> beer = new MyTuple<string, int, bool>(nameAndlittersBeer[0], int.Parse(nameAndlittersBeer[1]), IsDrunk);

            string[] intAndDoubleInfo = Console.ReadLine().Split();

            MyTuple<string, double, string> intAndDouble = new MyTuple<string, double, string>(intAndDoubleInfo[0], double.Parse(intAndDoubleInfo[1]), intAndDoubleInfo[2]);

            Console.WriteLine(person);
            Console.WriteLine(beer);
            Console.WriteLine(intAndDouble);
        }
    }
}
