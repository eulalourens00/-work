using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ildar_1para
{
    internal class Dragon: Enemy
    {
        public override void Fight()
        {
            Console.WriteLine("Dragon is flying... FIRE!");
        }
    }
}
