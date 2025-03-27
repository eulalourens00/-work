using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Pract
{
    internal class Store
    {
        public int AreaStore { get; set; }
        public int NewAddArea;
        public int NewSubArea;
        public Store(int area_store) { AreaStore = area_store; }

        public void AddArea()
        {
            Console.Write("Count of new area - ");
            Int32.TryParse(Console.ReadLine(), out int count);
            NewAddArea = count;
            AreaStore += NewAddArea;
            Console.Write($"\nCount of area now - {AreaStore}");
        }
        public void SubArea()
        {
            Console.Write("\nCount of sub area - ");
            Int32.TryParse(Console.ReadLine(), out int count);
            NewSubArea = count;
            Console.Write($"\nCount of area now - {AreaStore - count}");
        }
        public void EqualsArea()
        {
            if (NewAddArea.Equals(NewSubArea)) { Console.WriteLine("\nNot bad."); }
            else if (NewAddArea > NewSubArea) { Console.WriteLine("\nGreat."); }
            else { Console.WriteLine("\nWe have to rethink some things."); }
        }  
    }
}

