using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Атрибуты
{
    [Serializable]
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        int _identNum;

        [NonSerialized]
        const string Planet = "Earth";
    }
}
