using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Circle : Shapes
    {
        int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            area = (double)22 / 7 * radius * radius;
            return area;
        }

    }
}
