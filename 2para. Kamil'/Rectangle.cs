using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2para._Kamil_
{
    internal struct Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int GetArea()
        {
            return Width * Height; 
        }
    }
}
