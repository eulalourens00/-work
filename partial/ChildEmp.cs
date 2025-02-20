using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partial
{
    public class ChildEmp
    {
        protected string firstName;
        protected string lastName;
        DateTime _birthDate;
        public ChildEmp(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
        }

        public virtual void Show()
        {
            Console.WriteLine($"\nLast name = {lastName}\n Name = {firstName}\n Birth = {_birthDate.ToShortDateString()}");
        }
    }
    public class Employee: ChildEmp
    {
        double salary;
        public Employee(string fname, string lname, double salary) : base(fname, lname)
        {          
            this.salary = salary;
        }
        public sealed override void Show()
        {
            Console.WriteLine("Salary {salary}");
        }
    }
}
