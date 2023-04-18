using System;

namespace _12TradеCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double commission = 0;

            switch (town)
            {
                case "Sofia":

                    if (volume <= 500)
                    {
                        commission = volume * 5 / 100;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else if (volume <= 1000)
                    {
                        commission = volume * 7 / 100;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else if (volume <= 10000)
                    {
                        commission = volume * 8 / 100;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else
                    {
                        commission = volume * 12 / 100;
                        Console.WriteLine($"{commission:F2}");
                    }
                    break;
                case "Varna":

                    if (volume <= 500)
                    {
                        commission = volume * 4.5 / 100;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else if (volume <= 1000)
                    {
                        commission = volume * 7.5 / 100;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else if (volume <= 10000)
                    {
                        commission = volume * 10 / 100;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else
                    {
                        commission = volume * 13 / 100;
                        Console.WriteLine($"{commission:F2}");
                    }
                    break;
                case "Plovdiv":

                    if (volume >= 0 && volume <= 500)
                    {
                        commission = volume * 5.5 / 100;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else if (volume >= 0 && volume <= 1000)
                    {
                        commission = volume * 8 / 100;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else if (volume >= 0 && volume <= 10000)
                    {
                        commission = volume * 12 / 100;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else if (volume > 0 && volume > 10000f)                    
                    {
                        commission = volume * 14.5 / 100;
                        Console.WriteLine($"{commission:F2}");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }

            
        }
       
    }
}
