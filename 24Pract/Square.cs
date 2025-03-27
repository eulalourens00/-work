using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Pract
{
    internal class Square
    {
        public int Side { get; set; }
        public char SideChar { get; set; }
        public Square(int side, char side_char)
        {
            Side = side; SideChar = side_char;
        }
        public void Draw()
        {
            for (int i = 0; i < Side; i++)
            {
                for (int j = 0; j < Side; j++)
                { Console.Write(SideChar); }
                Console.WriteLine();
            }
        }
    }
}
