using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractBuilders
{
    internal class Product
    {
        ArrayList parts = new ArrayList();
        public void Add(string part)
        {
            parts.Add(part);
        }
        public void Show()
        {
            foreach (var part in parts)
            { Console.WriteLine(part); }
        }
    }
}
