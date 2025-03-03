using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_3_03._03._2025
{
    internal class Ellipse: GeometryFigures
    {
        public const double PI = 3.1415926535;
        public int Radius_mini { get; set; }
        public int Radius_max { get; set; }
        public Ellipse(int radius_mini, int radius_max)
        {
            Radius_mini = radius_mini;
            Radius_max = radius_max;
        }
        public override double Area()
        {
            double EllipseArea = PI * Radius_mini * Radius_max;
            Console.WriteLine($"Area of ellipse is {EllipseArea}");
            return EllipseArea;
        }
        public override double Perimeter()
        {
            double EllipsePerimeter = ((PI * Radius_mini * Radius_max) + (Radius_max - Radius_mini) / Radius_mini + Radius_max) * 4;
            Console.WriteLine($"Perimeter of ellipse is {EllipsePerimeter}");
            return EllipsePerimeter;
        }
    }
}
