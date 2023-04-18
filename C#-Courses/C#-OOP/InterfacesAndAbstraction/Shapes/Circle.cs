﻿using Shapes.Contracts;
using System;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private int radius;

        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius
        {
            get { return radius; }
            private set { radius = value; }
        }


        public void Draw()
        {
            double rIn = radius - 0.4;
            double rOut = radius + 0.4;
            for (double i = radius; i >= -radius; --i)
            {
                for (double j = -radius; j < rOut; j += 0.5)
                {
                    double value = j * j + i * i;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
