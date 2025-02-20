using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace перегрузка
{
    internal class Vector
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public Vector() { }
        public Vector(Point begin, Point end)
        {
            X = end.X - begin.X;
            Y = end.Y - begin.Y;
        }
        
        public static Vector operator + (Vector a, Vector b)
        {
            return new Vector
            {
                X = a.X + b.X,
                Y = a.Y + b.Y,
            };
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector
            {
                X = a.X - b.X,
                Y = a.Y - b.Y,
            };
        }

        public static Vector operator *(Vector a, int n) {
            a.X *= n;
            a.Y *= n;
            return a;
        }
        public static Vector operator *(int n, Vector a)
        {
            return a * n;
        }
        public override string ToString()
        {
            return $"Vector: X = {X}, Y = {Y}";
        }

    }
}
