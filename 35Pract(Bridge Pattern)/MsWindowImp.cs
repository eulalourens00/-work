using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35Pract_Bridge_Pattern_
{
    public class MSWindowImp : IWindowImp
    {
        public void DevDrawButton()
        { Console.WriteLine("Drawing Windows-style button");}

        public void DevDrawForm()
        { Console.WriteLine("Drawing Windows-style form");}
    }

    public class MacWindowImp : IWindowImp
    {
        public void DevDrawButton()
        { Console.WriteLine("Drawing Mac-style button");}

        public void DevDrawForm()
        { Console.WriteLine("Drawing Mac-style form"); }
    }
}
