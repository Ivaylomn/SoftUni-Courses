using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;

            toppings = new List<Topping>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException($"Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            }
        }

        public Dough Dough 
        {
            get => dough;
            set
            {
                dough = value;
            }
        }

        public IReadOnlyCollection<Topping> Toppings => toppings.AsReadOnly();

        public double TotoalCalories
            => toppings.Select(t => t.Calories).Sum() + Dough.Calories;

        public void AddTopping(Topping topping)
        {
            if (toppings.Count == 10)
            {
                throw new InvalidOperationException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }
    }
}
