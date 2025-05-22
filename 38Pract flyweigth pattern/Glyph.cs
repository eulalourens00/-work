using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38Pract_flyweigth_pattern
{
    public abstract class Glyph
    {
        public abstract void Draw(GraphicsContext context);
        public abstract bool Intersects(Point point, GraphicsContext context);

    }
}
