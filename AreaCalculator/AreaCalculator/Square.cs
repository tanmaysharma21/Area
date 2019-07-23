using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Square : Shapes
    {
        int side;
        public Square(int side)
        {
            this.side = side;
        }

        public override double CalculateArea()
        {
            area = side * side;
            return area;
        }

    }
}
