using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class GenericClass<T>
    {
        public void M1(T obj) {
            Console.WriteLine($"Parameter: {obj}");
        }
        public virtual void M2(T data)
        {
            Console.WriteLine($"Generic: {data}");
        }
    }
    class InheritClass: GenericClass<int>
    {
        public override void M2(int data)
        {
            Console.WriteLine($"Inherit: {data}");
        }
    }
}
