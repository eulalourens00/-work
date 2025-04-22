using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Pattern_3
{
    internal class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}
