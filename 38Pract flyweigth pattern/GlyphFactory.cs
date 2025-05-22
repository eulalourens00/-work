using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38Pract_flyweigth_pattern
{
    public class GlyphFactory
    {
        public Character CreateCharacter(char ch) => new Character(ch);
        public Column CreateColumn() => new Column();
        public Page CreatePage() => new Page();
        public Row CreateRow() => new Row();
    }
}
