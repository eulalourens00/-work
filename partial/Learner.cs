using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial
{
    abstract class Learner: AbsHuman
    {
        string _institution;
        public Learner(string fName, string lName, DateTime date, string instution):
            base(fName, lName, date)
        {
            _institution = instution;
        }
        public abstract void Study();
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Study in: {_institution}");
        }
        public override string ToString() { 
            return base.ToString() + $"Study in: {_institution}";
        }
    }
}
