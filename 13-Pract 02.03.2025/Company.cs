using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers._Pract_02._03._2025
{
    public abstract class Company
    {
        public string Name { get; set; }
        public int Quantity {  get; set; }
        public double Cost { get; set; }

        public Company(string name, int quantity, double cost)
        {
            Name = name;
            Quantity = quantity;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"{Name} - ({Quantity} ed. | {Cost} $)";
        }
        public void NewQuantity(int ed)
        {
            if (Quantity + ed < 0)
            {
                throw new InvalidOperationException("Quantity cannot be negative.");
            }
            Quantity += ed; // ed может быть меньше 0
        }
    }
}
