using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Pract___30._03._2025__Abstract_Class
{
    abstract class GeometryFigures:IComparable<GeometryFigures>
    {
        public abstract double Area();
        public abstract void Info();

        public int CompareTo(GeometryFigures other)
        {
            return this.Area().CompareTo(other.Area());
        }
    }
}
