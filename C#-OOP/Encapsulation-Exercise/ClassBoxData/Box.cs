using System;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double height;
        private double width;

        public Box(double length, double height, double width)
        {
            Length = length;
            Height = height;
            Width = width;
        }

        public double Length
        {
            get => length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }

                length = value;
            }
        }

        public double Height
        {
            get => height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }

                height = value;
            }
        }

        public double Width
        {
            get => width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }

                width = value;
            }
        }

        public double SurfaceArea()
            => 2 * length * width + 2 * length * height + 2 * width * height;

        public double LateralSurfaceArea()
            => 2 * length * height + 2 * width * height;

        public double Volume()
            => length * width * height;
    }
}
