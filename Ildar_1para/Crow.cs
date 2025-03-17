using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ildar_1para
{
    internal class Crow: IFlyable, IRunnable
    {
        public void Fly()
        {
            Console.WriteLine("Im flying..");
        }
        public void Run() {
            Console.WriteLine("Im running!");
        }
    }
}
