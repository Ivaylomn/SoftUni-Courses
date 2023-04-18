using System;
using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
			try
			{
                string[] pizzaName = Console.ReadLine().Split();
                string[] doughInput = Console.ReadLine().Split();

                Dough dough = new Dough(doughInput[1], doughInput[2], double.Parse(doughInput[3]));
                Pizza pizza = new Pizza(pizzaName[1], dough);

                string command = Console.ReadLine();

                while (command != "END")
                {
                    string[] toppingInput = command.Split();

                    Topping topping = new Topping(toppingInput[1], double.Parse(toppingInput[2]));

                    pizza.AddTopping(topping);
                    command = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotoalCalories:f2} Calories.");
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
