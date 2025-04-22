using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33Pract_Xml
{
    public class Order
    {
        public int Id { get; set; }
        public string? Customer { get; set; }
        public DateTime Date { get; set; }
        public Item[]? Items { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
