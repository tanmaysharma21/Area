using System;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Circle circle = new Circle(7);
            Console.WriteLine("Circle Area is " + circle.CalculateArea());
            Console.WriteLine("dfs");
        }
    }
}
