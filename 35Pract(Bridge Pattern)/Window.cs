using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35Pract_Bridge_Pattern_
{
    public abstract class Window
    {
        protected IWindowImp _implementor;
        public Window(IWindowImp implementor)
        {
            _implementor = implementor;
        }

        public abstract void Draw();
    }
}
