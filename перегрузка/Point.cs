using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace перегрузка
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Point operator ++(Point s)
        {
            s.X++;
            s.Y++;
            return s;
        }
        public static Point operator --(Point s) { 
            s.X--;
            s.Y--;
            return s;
        }
        public static Point operator -(Point s) // < 0
        {
            return new Point { X =-s.X, Y =-s.Y };
        }
        public override bool Equals(object? obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override string ToString()
        {
            return $"Point: X = {X}, Y = {Y}";
        }

        public static bool operator true(Point p)
        {
            return p.X != 0 || p.Y != 0 ? true : false ;
        }
        public static bool operator false(Point p)
        {
            return p.X == 0 || p.Y == 0 ? false : true;
        }
    }
}
