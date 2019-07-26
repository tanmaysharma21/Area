using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Triangle : Shape
    {
        public int side1, side2, side3;
        public Triangle(int side1, int side2, int side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override double CalculateArea()
        {
            double semiPerimeter = (double)(side1 + side2 + side3) / 2;
            double areaSquare = semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3);
            area = Math.Sqrt(areaSquare);
            return area;
        }

    }
}
