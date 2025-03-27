using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Pract
{
    internal class Magazine_Employees
    {
        public int CountEmployees { get; set; }
        public int NewADDEmployees;
        public int NewSUBEmployees;
        public Magazine_Employees( int count_employees) { CountEmployees = count_employees; }

        public void AddEmployee()
        {
            Console.Write("Count of new employees - ");
            Int32.TryParse(Console.ReadLine(), out int count);           
            NewADDEmployees = count;
            CountEmployees += NewADDEmployees;
            Console.Write($"\nCount of employees now - {CountEmployees}");
        }
        public void SubEmployee()
        {
            Console.Write("\nCount of dismissed employees - ");
            Int32.TryParse(Console.ReadLine(), out int count);
            NewSUBEmployees = count;
            Console.Write($"\nCount of employees now - {CountEmployees - count}");
        }
        public void EqualsEmployees()
        {
            if (NewADDEmployees.Equals(NewSUBEmployees)) { Console.WriteLine("\nNot bad."); }
            else if (NewADDEmployees > NewSUBEmployees) { Console.WriteLine("\nGreat."); }
            else { Console.WriteLine("\nWe have to rethink some things."); }
        }

    }
}
