using System;

namespace SquareLib
{
    public class Triangle : IFigure
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double a, double b, double c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            side1 = Math.Abs(a);
            side2 = Math.Abs(b);
            side3 = Math.Abs(c);
        }

        public double GetPerimeter()
        {
            return side1 + side2 + side3;
        }

        public double GetSquare()
        {
            double p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
    }
}
