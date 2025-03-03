using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_3_03._03._2025
{
    internal class Rectangle: GeometryFigures
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public Rectangle(int side_a, int side_b)
        {
            SideA = side_a;
            SideB = side_b;
        }

        public override double Area()
        {
            int RectangleArea = SideA * SideB;
            Console.WriteLine($"Area of rectangle is {RectangleArea}");
            return RectangleArea;
        }
        public override double Perimeter()
        {
            int RectanglePerimeter = (SideA + SideB) * 2;
            Console.WriteLine($"Perimeter of rectangle is {RectanglePerimeter}");
            return RectanglePerimeter;
        }
    }
}
