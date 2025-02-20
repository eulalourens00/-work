using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial
{
    partial class Human2
    {
        string firstName;
        string lastName;
        DateTime _birthDate;

        public Human2 (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Human2(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            _birthDate = birthDate;
        }
        public void Show()
        {
            Console.WriteLine($"\nLast name = {lastName}\n Name = {firstName}\n Birth = {_birthDate.ToShortDateString()}");
        }

    }
}
