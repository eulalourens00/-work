using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweigth_2_Дома
{
    abstract class House
    {
        protected int stages;
        public abstract void Build(double longitude, double latitude);
    }
}
