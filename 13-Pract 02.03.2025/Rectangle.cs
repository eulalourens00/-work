using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers._Pract_02._03._2025
{
    internal class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(int height, int width) {
            Height = height;
            Width = width;
        }
        public void Draw()
        {
            for(int i = 0; i < Height; i++)
            {
                for(int j = 0; j < Width; j++) { Console.Write("#"); }
                Console.WriteLine();
            }
        }
    }
}
