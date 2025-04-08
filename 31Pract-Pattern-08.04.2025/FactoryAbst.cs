using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Pract_Pattern_08._04._2025
{
    public abstract class FactoryAbst
    {
        abstract public WaterAbst CreateW();
        abstract public BottleAbst CreateB();
    }
}
