using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers._Pract_02._03._2025
{
    internal class Square
    {
        public int Side { get; set; }
        public Square(int side)
        {
            Side = side;
        }
        public void Draw()
        {
            for(int i = 0; i < Side; i++)
            {
                for (int j = 0; j < Side; j++)
                { Console.Write("@"); }
                Console.WriteLine();
            }
        }
    }
}
