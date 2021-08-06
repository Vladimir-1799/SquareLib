using System;

namespace SquareLib
{
    public class Circle : IFigure
    {
        private double radius;

        public Circle(double r)
        {
            if (r == 0) throw new ArgumentOutOfRangeException();
            radius = Math.Abs(r);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
