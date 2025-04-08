using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Pract_Pattern_08._04._2025
{
    public class PepsiF : FactoryAbst
    {
        public override PepsiB CreateB()
        {
            return new PepsiB();
        }

        public override PepsiW CreateW()
        {
            return new PepsiW();
        }
    }
}
