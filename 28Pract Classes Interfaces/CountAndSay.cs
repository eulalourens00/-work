using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28Pract_Classes_Interfaces
{
    public class CountSay
    {
        public static string CountAndSay(int n)
        {
            if (n < 1 || n > 30) { throw new ArgumentException("more 1 and less 30."); }
            string current = "1";

            for (int i = 1; i < n; i++)
            { current = GenerateNext(current); }

            return current;
        }

        private static string GenerateNext(string current)
        {
            StringBuilder result = new StringBuilder();
            int count = 1;

            for (int i = 1; i < current.Length; i++)
            {
                if (current[i] == current[i - 1])
                { count++; }
                else
                {
                    result.Append(count);
                    result.Append(current[i - 1]);
                    count = 1;
                }
            }
            result.Append(count);
            result.Append(current[current.Length - 1]);

            return result.ToString();
        }
    }
}
