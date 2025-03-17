using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ildar_1para
{
    internal class Vehicle
    {
        public virtual void Move()
        {
            Console.WriteLine("Mooooviiing...");
        }
    }
    internal class Car : Vehicle {
        public override void Move()
        {
            Console.WriteLine("Car is mooovinnng...");
        }
    }
}
