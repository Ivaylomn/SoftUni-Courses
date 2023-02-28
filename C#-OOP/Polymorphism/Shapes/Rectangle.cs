namespace Shapes
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Height
        {
            get { return height; }
            private set { height = value; }
        }

        public double Width
        {
            get { return width; }
            private set { width = value; }
        }


        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override double CalculatePerimeter()
            => (Height + Width) * 2;

        public override string Draw()
        {
            return $"{base.Draw()}{this.GetType().Name}";
        }
    }
}
