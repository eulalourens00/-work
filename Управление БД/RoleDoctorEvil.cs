using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Управление_БД
{
    internal class RoleDoctorEvil: Flyweigth
    {
        Flyweigth Flyweigth;
        public RoleDoctorEvil(Flyweigth flyweigth)
        {
            Flyweigth = flyweigth;
        }
        public override void Greeting(string speech)
        {
            Flyweigth.Greeting(speech);
        }
    }
}
