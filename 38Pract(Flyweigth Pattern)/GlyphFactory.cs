using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38Pract_Flyweigth_Pattern_
{
    public class GlyphFactory
    {
        private Dictionary<char, Character> _characters = new Dictionary<char, Character>();
        private Row _row = new Row();
        private Column _column = new Column();

        public Character GetCharacter(char c)
        {
            if (!_characters.ContainsKey(c))
            { _characters[c] = new Character(c);}
            return _characters[c];
        }

        public Row GetRow()
        { return _row;}

        public Column GetColumn()
        {   return _column; }
    }

}
