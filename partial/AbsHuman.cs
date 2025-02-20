using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial
{
    public abstract class AbsHuman
    {
        string _firstName;
        string _lastName;
        DateTime _birthDate;

        public AbsHuman(string firstName, string lastName, DateTime birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
        }

        public abstract void Think();

        public virtual void Print()
        {
            Console.WriteLine($"\nLast name: { _lastName}\nName: {_firstName}\nDate: {_birthDate.ToLongDateString()} ");
        }
        //same func (print/ToString)
        public override string ToString()
        {
            return ($"\nLast name: {_lastName}\nName: {_firstName}" +
                $"\nDate: {_birthDate.ToLongDateString()} ");
        }
    }
}
