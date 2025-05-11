using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35Pract_Bridge_Pattern_
{
    public class MSWindow : Window
    {
        public MSWindow(IWindowImp implementor) : base(implementor) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing MS Window:");
            _implementor.DevDrawForm();
            _implementor.DevDrawButton();
        }
    }

    public class MacWindow : Window
    {
        public MacWindow(IWindowImp implementor) : base(implementor) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing Mac Window:");
            _implementor.DevDrawForm();
            _implementor.DevDrawButton();
        }
    }
}
