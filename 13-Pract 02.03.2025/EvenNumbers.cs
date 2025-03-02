using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers._Pract_02._03._2025
{
    internal class EvenNumbers
    {
        Random rnd = new Random();
        public int[] Numbers;
        public int Startdiaposon {  get; set; }
        public int Enddiaposon { get; set; }

        public EvenNumbers(int startdiaposon, int enddiaposon)
        {
            Startdiaposon = startdiaposon;
            Enddiaposon = enddiaposon;
        }

        public void Result()
        {
            List<int> evenNumbers = new List<int>();
            if (Startdiaposon > Enddiaposon)
            { Console.WriteLine("Invalid range."); }

            for (int i = Startdiaposon; i <= Enddiaposon; i++)
            {
                if (i % 2 == 0)
                { evenNumbers.Add(i);}
            }

            Console.WriteLine("Even numbers:");
            foreach (var number in evenNumbers)
            { Console.Write(number + " ");}
        }
     }
}
