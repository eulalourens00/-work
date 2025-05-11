using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33Pract
{
    //3
    public class Line<T> where T : struct
    {
        public Point2D<T> Point1 { get; set; }
        public Point2D<T> Point2 { get; set; }

        public Line(Point2D<T> p1, Point2D<T> p2)
        {
            Point1 = p1;
            Point2 = p2;
        }

        public Line(T x1, T y1, T x2, T y2)
        {
            Point1 = new Point2D<T>(x1, y1);
            Point2 = new Point2D<T>(x2, y2);
        }

        public override string ToString()
        {
            return $"Cross {Point1} and {Point2}";
        }
    }
}
