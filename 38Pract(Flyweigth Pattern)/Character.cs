using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38Pract_Flyweigth_Pattern_
{
    public class Character : Glyph
    {
        private readonly char _symbol;

        public Character(char symbol)
        { _symbol = symbol;}

        public override void Draw(int x, int y)
        { Console.WriteLine($"Drawing '{_symbol}' at ({x}, {y})");}
    }

    public class Row : Glyph
    {
        public override void Draw(int x, int y)
        { Console.WriteLine($"Drawing row at y={y}");}
    }

    public class Column : Glyph
    {
        public override void Draw(int x, int y)
        { Console.WriteLine($"Drawing column at x={x}");}
    }
}
