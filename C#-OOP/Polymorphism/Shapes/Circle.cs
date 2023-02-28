using System;
using System.Text.RegularExpressions;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            private set { radius = value; }
        }

        public override double CalculateArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Radius * Math.PI;
        }

        public override string Draw()
        {
            return base.Draw() + GetType().Name;
        }
    }
}
