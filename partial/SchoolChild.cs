using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace partial
{
    internal class SchoolChild: Learner
    {
        string _className;

        public SchoolChild(string fName, string lName, DateTime date,
            string inst, string className):
            base(fName, lName, date, inst)
        {
            _className = lName;
        }

        public override void Think()
        {
            WriteLine($"I think like a school kid");
        }

        public override void Study()
        {
            WriteLine($"Im in school");
        }
        public override void Print()
        {
            base.Print();
            WriteLine($"Im in {_className} class");
        }
        public override string ToString()
        {
            return base.ToString() + $"Im in {_className} class";
        }
    }

}
