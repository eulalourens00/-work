using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38Pract_flyweigth_pattern
{
    public class Character: Glyph
    {
        private char _char;

        public Character(char ch) { _char = ch; }
        public override void Draw(GraphicsContext context)
        { Console.WriteLine($"Drawing... Magic! Look: {_char} at {context.Position}"); }

        public override bool Intersects(Point point, GraphicsContext context)
        {
            return context.Position.X <= point.X && point.X <= context.Position.X + 10 &&
                context.Position.Y <= point.Y && point.Y <= context.Position.Y +10;
        }
    }
}
