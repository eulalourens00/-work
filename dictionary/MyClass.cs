using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    internal class MyClass:Interface1
    {
        public void Move()
        {
            Console.WriteLine("RUN");
        }
        public string Name { get; set; }
    }
}
