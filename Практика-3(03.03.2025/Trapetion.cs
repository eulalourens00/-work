using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_3_03._03._2025
{
    internal class Trapetion: GeometryFigures
    {
        public int A_footing {  get; set; }
        public int B_footing { get; set; }
        public int C {  get; set; }
        public int D { get; set; }
        public int Heigth { get; set; }
        public Trapetion(int a_footing, int b_footing, int c, int d, int height) {
            A_footing = a_footing;
            B_footing = b_footing;
            C = c;
            D = d;
            Heigth = height;
        }
        public override double Area()
        {
            int TrapetionArea = ((A_footing + B_footing) / 2) * Heigth;
            Console.WriteLine($"Area of trapetion is {TrapetionArea}");
            return TrapetionArea;
        }
        public override double Perimeter()
        {
            int TrapetionPerimeter = A_footing + B_footing + C + D;
            Console.WriteLine($"Perimeter of trapetion is {TrapetionPerimeter}");
            return TrapetionPerimeter;
        }
    }
}
