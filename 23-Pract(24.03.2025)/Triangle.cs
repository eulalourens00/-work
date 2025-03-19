using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Pract_24._03._2025_
{
    internal class Triangle
    {
        public int Height { get; set; }

        public Triangle(int height)
        {
            Height = height;
        }

        public void Draw()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Height - i - 1; j++)
                { Console.Write(" "); }

                for (int k = 0; k < 2 * i + 1; k++)
                { Console.Write("*"); }

                Console.WriteLine();
            }
        }
    }
}
