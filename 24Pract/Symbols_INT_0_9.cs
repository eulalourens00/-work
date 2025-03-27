using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Pract
{
    internal class Symbols_INT_0_9
    {
        public void GetInt()
        {
            Console.WriteLine("Enter a combination of the symbols in the diapason 0 - 9: ");
            string res = Console.ReadLine().Trim();
            int[] ints = res.Select(c => (int)char.GetNumericValue(c)).ToArray();
            bool flag = true;
            foreach (int i in ints) { 
                if(i >= 0 && i <= 9) { continue; }
                else { flag = false; break; }
            }
            if (!flag) { throw new InvalidDataException(); }
            else
            {
                Console.Write("Combination: ");
                foreach (int i in ints) { Console.Write($"- {i} - "); }
            }            
        }
    }
}
