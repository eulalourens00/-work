using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28Pract_Classes_Interfaces
{
    public class Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person2(string name, int age) { Name = name; Age = age; }

        //1
        public override bool Equals(object? obj)
        {
            if (obj is null) { return false; }
            if (obj.GetType() != this.GetType()) { return false; }
            Person2 other = (Person2)obj;
            return this.Name == other.Name && this.Age == other.Age;
        }

        public override int GetHashCode()
        { return HashCode.Combine(Name, Age); }

        public static bool operator ==(Person2 left, Person2 right)
        {
            if (left is null) { return right is null; }
            return left.Equals(right);
        }

        public static bool operator !=(Person2 left, Person2 right)
        {
            return !(left == right);
        }

        public virtual object DeepCopy() { return new Person2(this.Name, this.Age); }

    }
}