using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_3_03._03._2025
{
    internal class ToStringMethods
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
        public string Hobbies { get; set; }
        
        public ToStringMethods(string firstName, string lastName, int age, DateTime birth, string hobbies)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            BirthDay = birth;
            Hobbies = hobbies;
        }

        public override string ToString()
        {
            return $"Im {LastName} {FirstName}. \nIm {Age}. My birthday is {BirthDay.ToShortDateString()}. \nI like {Hobbies}.";
        }
    }
}
