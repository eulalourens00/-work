using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37Pract_Composite_Pattern_
{
    public interface IGraphic
    {
        void Draw();
        void Add(IGraphic graphic);
        void Remove(IGraphic graphic);
        IGraphic GetChild(int index);
    }
}
