using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace перегрузка
{
    internal class Shop
    {
        Laptop[] laptopArr;
        public Shop(int sise)
        {
            laptopArr = new Laptop[sise];
        }
        public int Length
        {
            get { return laptopArr.Length; }
        }

        public Laptop this[int index]
        {
            get
            {
                if(index >= 0 && index < laptopArr.Length)
                {
                    return laptopArr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set { 
                laptopArr[index] = value;
            }
        }

    }
}
