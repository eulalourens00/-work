using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Pattern_3
{
    internal class Camel: IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Верблюд идет по пескам чух чух чух");
        }
    }
}
