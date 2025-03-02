using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers._Pract_02._03._2025
{
    public class HouseChemicals : Company
    {
        public DateTime SrokDognosty { get; set; }

        public HouseChemicals(string name, int quantity, double cost, DateTime srokDognosty)
            : base(name, quantity, cost)
        {
            SrokDognosty = srokDognosty;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nExpiration date {SrokDognosty.ToShortDateString()}";
        }
        public bool Problem()
        {
            return DateTime.Now > SrokDognosty;
        }
    }
}
