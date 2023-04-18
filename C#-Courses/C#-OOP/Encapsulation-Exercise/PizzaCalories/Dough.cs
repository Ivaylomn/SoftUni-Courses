using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Dough
    {
        Dictionary<string, double> flourTypes = new Dictionary<string, double>()
        {
            { "white", 1.5 },
            { "wholegrain" , 1.0 }
        };

        Dictionary<string, double> bakingTechniques = new Dictionary<string, double>()
        {
            { "crispy", 0.9 },
            { "chewy" , 1.1 },
            { "homemade" , 1.0 }
        };

        private string flourType;
        private string bakingTechnique;
        private double grams;

        public Dough(string flourType, string bakingTechnique, double grams)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Grams = grams;
        }

        public string FlourType
        {
            get { return flourType; }
            private set
            {
                if (!flourTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                flourType = value;
            }
        }

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {
                if (!bakingTechniques.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                bakingTechnique = value;
            }
        }

        public double Grams
        {
            get { return grams; }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                grams = value;
            }
        }

        public double Calories
            => 2 * Grams * flourTypes[FlourType.ToLower()] * bakingTechniques[BakingTechnique.ToLower()];
    }
}
