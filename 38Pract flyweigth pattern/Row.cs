using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38Pract_flyweigth_pattern
{
    public class Row: Glyph
    {
        private readonly List<Glyph> _children = new List<Glyph>();

        public override void Draw(GraphicsContext context)
        {
            var originalX = context.Position.X;
            foreach (var child in _children)
            {
                child.Draw(context);
                context.Position = new Point(context.Position.X + 10, context.Position.Y);
            }
            context.Position = new Point(originalX, context.Position.Y + 15);
        }

        public override bool Intersects(Point point, GraphicsContext context)
        {
            var tempPosition = context.Position;
            foreach (var child in _children)
            {
                if (child.Intersects(point, context))
                    return true;
                context.Position = new Point(context.Position.X + 10, context.Position.Y);
            }
            context.Position = tempPosition;
            return false;
        }
        public void Add(Glyph glyph) => _children.Add(glyph);
    }
}
