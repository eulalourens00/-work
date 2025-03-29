using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Pract___30._03._2025__Abstract_Class
{
    internal class Circle : GeometryFigures
    {
        public const double PI = 3.1415926535;
        public int Radius { get; set; }
        public Circle(int radius) { Radius = radius; }

        public override double Area()
        {
            double CircleArea = PI * Math.Pow(Radius, 2);
            //Console.WriteLine($"Area of circle is {CircleArea}");
            return CircleArea;
        }
        public override void Info()
        {
            Console.WriteLine($"Its a circle ({Radius})");
        }
    }
}
