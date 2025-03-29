using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Pract___30._03._2025__Abstract_Class
{
    internal class Line : Function
    {
        public double A, B;
        public Line(double a, double b) { A = a; B = b; }
        public override double Calculate(double x)
        { return A * x + B; }

        public override void Info()
        { Console.WriteLine($"Line: y = {A}x + {B}"); }

        public override double GetA()
        { return A; }
    }
}
