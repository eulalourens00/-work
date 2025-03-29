using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Pract___30._03._2025__Abstract_Class
{
    internal class Kub : Function
    {
        public double a;
        public double b;
        public double c;

        public Kub(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        public override double Calculate(double x)
        { return a * Math.Pow(x, 3) + b * x + c; }

        public override void Info()
        { Console.WriteLine($"Kub: y = {a}x^3 + {b}x + {c}");  }

        public override double GetA()
        { return a; }
    }
}
