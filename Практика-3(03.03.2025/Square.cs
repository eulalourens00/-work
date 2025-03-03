using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_3_03._03._2025
{
    internal class Square : GeometryFigures
    {
        public int Side1 { get; set; }

        public Square(int side1) { Side1 = side1; }

        public override double Area()
        {
            double SquareArea = Math.Pow(Side1, 2);
            Console.WriteLine($"Area of square is {SquareArea}");
            return SquareArea;
        }
        public override double Perimeter()
        {
            int SquarePerimeter = Side1 * 4;
            Console.WriteLine($"Perimeter of square is {SquarePerimeter}");
            return SquarePerimeter;
        }
    }
}
