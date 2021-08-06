using NUnit.Framework;
using SquareLib;
using System;

namespace SquareLibNUnitTest
{
    public class Tests
    {

        public void NewCircleException()
        {
            IFigure figure = new Circle(0);
        }

        public void NewTriangleException()
        {
            IFigure figure = new Triangle(0, 1, 2);
        }

        [Test]
        public void TestCalculations()
        {
            IFigure circle = new Circle(2);
            IFigure triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(4 * Math.PI, circle.GetPerimeter());
            Assert.AreEqual((double)12, triangle.GetPerimeter());
            Assert.AreEqual(Math.PI * Math.Pow(2, 2), circle.GetSquare());
            Assert.AreEqual((double)6, triangle.GetSquare());
        }

        [Test]
        public void TestOutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(NewCircleException);
            Assert.Throws<ArgumentOutOfRangeException>(NewTriangleException);
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                IFigure figure = new Triangle(0, 0, 0);
            });
        }
    }
}