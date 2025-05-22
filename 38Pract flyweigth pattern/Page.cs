using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38Pract_flyweigth_pattern
{
    public class Page : Glyph
    {
        private readonly List<Glyph> _children = new List<Glyph>();

        public override void Draw(GraphicsContext context)
        {
            Console.WriteLine("=== PAGE START ===");
            foreach (var child in _children)
            {
                child.Draw(context);
            }
            Console.WriteLine("=== PAGE END ===");
        }

        public override bool Intersects(Point point, GraphicsContext context)
        {
            return _children.Any(child => child.Intersects(point, context));
        }

        public void Add(Glyph glyph) => _children.Add(glyph);
    }
}
