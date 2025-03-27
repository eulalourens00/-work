using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_Камиль_
{
    //1.
    internal class Operation
    {
        public delegate int OperationDelegate(int a, int b);
        public int Summa(int a, int b)
        {
            return a + b;
        }
    }
    //2.
    internal class Filter
    {
        public delegate bool FilterDelegate(int num);
        public void Check()
        {
            Console.Write("Values (count of numbers cant be more 10): ");
            int[] values = new int[10];
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int val)) { values[count] = val; count++; }
                else { Console.WriteLine("Silly.. You lost it"); continue; }
            }
            Console.WriteLine("Massive: ");
            foreach (int i in values)
            { Console.Write(i + " "); }
            Console.WriteLine();

            FilterDelegate isEven = (number) => number % 2 == 0;

            Console.WriteLine("Now here are your numbers that are even: ");
            foreach (int a in values)
            {
                if (isEven(a))
                { Console.Write(a + " "); }
            }

        }
    }
}
