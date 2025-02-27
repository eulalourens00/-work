using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    internal interface Interface1
    {
        const int minSpeed = 0;
        static int maxSpeed = 60;
        void Move();
        string Name { get; set; }

    }
}
