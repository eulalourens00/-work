using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38Pract_flyweigth_pattern
{
    public class Column : Glyph
    {
        private readonly List<Glyph> _children = new List<Glyph>();

        public override void Draw(GraphicsContext context)
        {
            var originalY = context.Position.Y;
            foreach (var child in _children)
            {
                child.Draw(context);
                context.Position = new Point(context.Position.X, context.Position.Y + 15);
            }
            context.Position = new Point(context.Position.X + 100, originalY);
        }

        public override bool Intersects(Point point, GraphicsContext context)
        {
            var tempPosition = context.Position;
            foreach (var child in _children)
            {
                if (child.Intersects(point, context))
                    return true;
                context.Position = new Point(context.Position.X, context.Position.Y + 15);
            }
            context.Position = tempPosition;
            return false;
        }

        public void Add(Glyph glyph) => _children.Add(glyph);
    }
}
