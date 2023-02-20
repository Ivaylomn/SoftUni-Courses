using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Topping
    {
        Dictionary<string, double> toppings = new Dictionary<string, double>()
        {
            {"meat", 1.2},
            {"veggies", 0.8},
            {"cheese", 1.1},
            {"sauce", 0.9}
        };

        private string type;
        private double grams;

        public Topping(string type, double grams)
        {
            Type = type;
            Grams = grams;
        }

        public string Type
        {
            get { return type; }
            private set 
            {
                if (!toppings.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                
                type = value; 
            }
        }

        public double Grams
        {
            get { return grams; }
            private set 
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                }
                
                grams = value; 
            }
        }

        public double Calories
            => 2 * Grams * toppings[Type.ToLower()]; 
    }
}
