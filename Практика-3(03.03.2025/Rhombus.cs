using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_3_03._03._2025
{
    internal class Rhombus: GeometryFigures
    {
        public int A_diagonal { get; set; }
        public int B_diagonal { get; set; }
        public int Side1 { get; set; }
        public Rhombus(int a_diagonal, int b_diagonal, int side1)
        {
            A_diagonal = a_diagonal;
            B_diagonal = b_diagonal;
            Side1 = side1;
        }

        public override double Area()
        {
            int RhombusArea = (A_diagonal * B_diagonal) / 2;
            Console.WriteLine($"Area of rhombus is {RhombusArea}");
            return RhombusArea;
        }
        public override double Perimeter()
        {
            int RhombusPerimeter = Side1 * 4;
            Console.WriteLine($"Perimeter of rhombus is {RhombusPerimeter}");
            return RhombusPerimeter;
        }
    }
}
