using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Pract
{
    internal class Palindrom
    {
        public void Check()
        {
            Console.WriteLine("Let's check your combination of numbers!");
            string res = Console.ReadLine().Trim();
            int[] ints = res.Select(c => (int)char.GetNumericValue(c)).ToArray();

            bool flag = true;
            for (int i = 0; i < ints.Length / 2; i++) {
                if (ints[i] == ints[ints.Length - 1 - i]) { continue; }
                else { flag = false; break; }
 
            }
            if (flag) { Console.WriteLine("Great! Its a palindrom!"); }
            else { Console.WriteLine("Something's bad..."); }
        }
    }
}
