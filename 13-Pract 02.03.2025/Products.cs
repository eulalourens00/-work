using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers._Pract_02._03._2025
{
    internal class Products : Company 
    {
        public DateTime SrokDognosty { get; set; }

        public Products(string name, int quantity, double cost, DateTime srokDognosty)
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
