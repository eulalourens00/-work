using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38Pract_flyweigth_pattern
{
    public class GraphicsContext
    {
        public Point Position { get; set; }

        public GraphicsContext(int x, int y)
        { Position = new Point(x, y); }
    }

    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"({X}, {Y})";
    }
}
