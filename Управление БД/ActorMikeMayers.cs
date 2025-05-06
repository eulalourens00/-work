using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Управление_БД
{
    internal class ActorMikeMayers: Flyweigth
    {
        public override void Greeting(string speech)
        {
            Console.WriteLine(speech);
        }
    }
}
