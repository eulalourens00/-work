using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial
{
    internal class Student: Learner
    {
        string _groupName;
        public Student(string fName, string lName, DateTime date, string institution,
            string groupName): base(fName, lName, date, institution)
        {
            _groupName = groupName;
        }

        public override void Think()
        {
            Console.WriteLine("I think like a student");
        }
        public override void Study()
        {
            Console.WriteLine("Im studeing");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Im in {_groupName} group");
        }
        public override string ToString()
        {
            return base.ToString() + $"Im in {_groupName} group";
        }
    }
}
