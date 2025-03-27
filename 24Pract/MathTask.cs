using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Pract
{
    internal class MathTask
    {
        public void Task()
        {
            Console.WriteLine("\tTask:");
            string input = Console.ReadLine();

            string[] task = input.Split('*');
            List<int> ints = new List<int>();

            for (int index = 0; index < task.Length; index++)
            {
                if (Int32.TryParse(task[index], out int value))
                { ints.Add(value); }
                else
                { throw new InvalidDataException(); }
            }
            int i = 1;
            foreach (int ia in ints)
            { i *= ia; }
            Console.Write("Result: {0}", i);
        }
    }
}
