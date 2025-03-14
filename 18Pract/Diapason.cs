using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18Pract
{
    internal class Diapason
    {
        public int Start {  get; set; }
        public int End { get; set; }
        public Diapason(int start, int end) { Start = start; End = end; }
        public int Factorial()
        {
            int mul = 1;
            for (int i = Start; i <= End; i++) { mul *= i; }
            return mul;
        }
    }
}
