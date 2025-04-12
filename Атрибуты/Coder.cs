using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Атрибуты
{
    [Coder]
    internal class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        [Coder("John", "2017-03-12")]
        public void IncreaseWages(double wage )
        {
            Salary += wage;
        }
    }
}
