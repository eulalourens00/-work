using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_3_03._03._2025
{
    internal class Parallelogram: GeometryFigures
    {
        public int A_footing { get; set;}
        public int B_footing { get; set;}
        public int Height { get; set;}
        public Parallelogram(int a_footing, int b_footing, int height)
        {
            A_footing = a_footing;
            B_footing = b_footing;
            Height = height;
        }

        public override double Area()
        {
            int ParallelogramArea = A_footing * Height;
            Console.WriteLine($"Area of parallelogram is {ParallelogramArea}");
            return ParallelogramArea;
        }
        public override double Perimeter()
        {
            int ParallelogramPerimeter = (A_footing + B_footing) * 2;
            Console.WriteLine($"Perimeter of parallelogram is {ParallelogramPerimeter}");
            return ParallelogramPerimeter;
        }
    }
}
