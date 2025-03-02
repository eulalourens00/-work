using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers._Pract_02._03._2025
{
    internal class NotEvenNumbers
    {
        Random rnd = new Random();
        public int[] Numbers;
        public int Startdiaposon { get; set; }
        public int Enddiaposon { get; set; }

        public NotEvenNumbers(int startdiaposon, int enddiaposon)
        {
            Startdiaposon = startdiaposon;
            Enddiaposon = enddiaposon;
        }

        public void Result()
        {
            List<int> notevenNumbers = new List<int>();
            if (Startdiaposon > Enddiaposon)
            { Console.WriteLine("Invalid range."); }

            for (int i = Startdiaposon; i <= Enddiaposon; i++)
            {
                if (i % 2 != 0)
                { notevenNumbers.Add(i); }
            }

            Console.WriteLine("Not Even numbers:");
            foreach (var number in notevenNumbers)
            { Console.Write(number + " "); }
        }
    }
}
