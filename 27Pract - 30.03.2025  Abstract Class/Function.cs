using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Pract___30._03._2025__Abstract_Class
{
    abstract class Function : IComparable<Function>
    {
        public abstract double Calculate(double x);
        public abstract void Info();

        public int CompareTo(Function other)
        { return GetA().CompareTo(other.GetA());}
        public abstract double GetA();
    }
}
