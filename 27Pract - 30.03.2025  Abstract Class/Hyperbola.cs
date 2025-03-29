using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Pract___30._03._2025__Abstract_Class
{
    internal class Hyperbola : Function
    {
        public double a;
        public Hyperbola(double A)
        {
            a = A;
        }
        public override double Calculate(double x)
        { return a / x;}

        public override void Info()
        { Console.WriteLine($"Hyperbola: y = {a}/x"); }

        public override double GetA()
        { return a; }
    }
}
