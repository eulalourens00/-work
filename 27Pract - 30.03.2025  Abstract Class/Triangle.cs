using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Pract___30._03._2025__Abstract_Class
{
    internal class Triangle : GeometryFigures
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Height { get; set; }

        public Triangle(int side1, int side2, int side3, int height)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Height = height;
        }

        public override double Area()
        {
            int TriangleArea = (Side1 * Height) / 2;
            //Console.WriteLine($"Area of triangle is {TriangleArea}");
            return TriangleArea;
        }
        public override void Info()
        {
            Console.WriteLine($"Its a triangle ({Side1}, {Side2}, {Side3})");
        }
    }
}
