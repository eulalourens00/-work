using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Pract_Pattern_08._04._2025
{
    public class Client
    {
        private BottleAbst bottle;
        private WaterAbst water;

        public Client(FactoryAbst factory)
        {
            bottle = factory.CreateB();
            water = factory.CreateW();
        }

        public void Print()
        {
            bottle.Interact(water);
        }
    }
}
