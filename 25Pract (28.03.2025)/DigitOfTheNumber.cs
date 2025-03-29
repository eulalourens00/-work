using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25Pract__28._03._2025_
{
    internal class DigitOfTheNumber
    {
        private int _value;

        public int this[int index]
        {
            get
            {
                // 10^0=1; 10^1=10; 10^2=100 ....
                return (_value / (int)Math.Pow(10, index)) % 10;
            }
            set
            {
                int digit = value % 10;
                _value = (_value / (int)Math.Pow(10, index + 1)) * (int)Math.Pow(10, index + 1) + (digit * (int)Math.Pow(10, index)) + (_value % (int)Math.Pow(10, index));
            }
        }
    }
}
