using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Facade
{
    internal class Facade
    {
        SubSystem1 subSystem1 = new SubSystem1();
        SubSystem2 subSystem2 = new SubSystem2();
        SubSystem3 subSystem3 = new SubSystem3();
        SubSystem4 subSystem4 = new SubSystem4();

        public void Operation1_2()
        {
            subSystem1.Operation1();
            subSystem2.Operation2();

        }
        public void Operation3_4()
        {
            subSystem3.Operation3();
            subSystem4.Operation4();

        }
    }
}
