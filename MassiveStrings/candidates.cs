using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiveStrings
{
    internal class Candidates
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public DateTime birthDate { get; set; }

        public Candidates(string fullname, string address, DateTime birthday)
        {
            FullName = fullname;
            Address = address;
            birthDate = birthday;
        }
        DateTime currentDate = DateTime.Now;
        public int Age()
        {
            int age = currentDate.Year - birthDate.Year;
            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--;
            }    
            return age;            
        }
    }
}
