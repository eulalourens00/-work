using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27Pract___30._03._2025__Abstract_Class
{
    abstract class Massive
    {
        protected int[] Values;
        protected Massive(int size)
        {
            Values = new int[size];
            for (int i = 0; i < size; i++) { Values[i] = (i + 1) * 4; } /*заполняем числами от 0 до сайз, но умноженными на 4. это не было условием*/
        }
        public int Size_Values
        {
            get { return Values.Length; }
        }
        public abstract void Info();
        public abstract int this[int index]  { get; set; }
    }
}
