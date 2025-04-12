using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сериализация_и_Дисериализация
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private int _identityNumber = 443;

        [NonSerialized]
        public const string Planet = "Earth";

        public Person() { }
        public Person(string name, int age) { Name = name; Age = age; }

        public override string ToString() { return $"Name - {Name}, Age - {Age}, Id - {_identityNumber} "
                + $"Planet - {Planet}"; }
    }
}
