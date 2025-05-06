using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Управление_БД
{
    internal class RoleAustinPowers: Flyweigth
    {
        Flyweigth _flyweigth;
        public RoleAustinPowers(Flyweigth flyweigth)
        {
            _flyweigth = flyweigth;
        }
        public override void Greeting(string speech)
        {
            _flyweigth.Greeting(speech);
        }
    }
}
