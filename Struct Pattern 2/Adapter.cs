using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Pattern_2
{
    internal class Adapter: Target
    {
        Adaptee adaptee = new Adaptee();
        public override void Requst()
        {
            adaptee.SpecificRequest();
        }
    }
}
