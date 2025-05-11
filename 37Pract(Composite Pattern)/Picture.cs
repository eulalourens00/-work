using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37Pract_Composite_Pattern_
{
    public class Picture : IGraphic
    {
        private string _name;
        private List<IGraphic> _children = new List<IGraphic>();

        public Picture(string name)
        { _name = name;}

        public void Draw()
        {
            Console.WriteLine($"Рисуем изображение: {_name}");
            foreach (var child in _children)
            { child.Draw(); }
        }

        public void Add(IGraphic graphic)
        { _children.Add(graphic);}

        public void Remove(IGraphic graphic)
        { _children.Remove(graphic); }

        public IGraphic GetChild(int index)
        { return _children[index]; }
    }
}
