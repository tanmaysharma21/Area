using AreaCalculator;
using System;
using Xunit;

namespace AreaTesting
{
    public class UnitTest1
    {
        double area;

        [Fact]
        public void CircleArea()
        {
            Circle circle = new Circle(7);
            area = circle.CalculateArea();
            Assert.Equal(154, area);
        }

        [Fact]
        public void RectangleArea()
        {
            Rectangle rectangle = new Rectangle(5, 7);
            area = rectangle.CalculateArea();
            Assert.Equal(35, area);
        }

        [Fact]
        public void SquareArea()
        {
            Square square = new Square(8);
            area = square.CalculateArea();
            Assert.Equal(64, area);
        }

        [Fact]
        public void TriangleArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            area = triangle.CalculateArea();
            Assert.Equal(6, area);
        }

    }
}
