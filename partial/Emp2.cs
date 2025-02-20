using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial
{
   sealed internal class Emp2:Human2
    {
        double salary;
        public Emp2(string fName, string lName): base(fName, lName) { }

        public Emp2(string fName, string lName, double salary)
            :base(fName, lName)
        {
            this.salary = salary;
        }
        public void Print()
        {
            Show();
            Console.WriteLine($"Salary = {salary}");
        }
    }
}
