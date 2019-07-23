using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Rectangle : Shapes
    {
        int length, breadth;
        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }

        public override double CalculateArea()
        {
            area = length * breadth;
            return area;
        }

    }
}
