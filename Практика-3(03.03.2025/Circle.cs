using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_3_03._03._2025
{
    internal class Circle: GeometryFigures
    {
        public const double PI = 3.1415926535;
        public int Radius { get; set; }
        public Circle(int radius) { Radius = radius; }

        public override double Area()
        {
            double CircleArea = PI * Math.Pow(Radius, 2);
            Console.WriteLine($"Area of circle is {CircleArea}");
            return CircleArea;
        }
        public override double Perimeter()
        {
            double CirclePerimeter = 2 * PI * Radius;
            Console.WriteLine($"Perimeter of circle is {CirclePerimeter}");
            return CirclePerimeter;
        }
    }
}
