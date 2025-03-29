using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Pract___30._03._2025__Abstract_Class
{
    internal class Rectangle : GeometryFigures
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
            //Console.WriteLine($"Area of rectangle is {RectangleArea}");
            return RectangleArea;
        }
        public override void Info()
        {
            Console.WriteLine($"Its a rectangle ({SideA}, {SideB})");
        }
    }
}
