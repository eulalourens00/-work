using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial
{
    internal class Emp:Human
    {
        double _salary;

        public Emp(string fName, string lName, double salary)
        {
            firstName = fName;
            lastName = lName;
            _salary = salary;
        }
        public void Test()
        {
            firstName = "null";
        }
        public void Print()
        {
            Console.WriteLine($"Last Name = {lastName},\nName = {firstName},\nSalary = {_salary}");
        }
    }
}
