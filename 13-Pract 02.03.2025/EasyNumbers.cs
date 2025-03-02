using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers._Pract_02._03._2025
{
    internal class EasyNumbers
    {
        Random rnd = new Random();
        public int[] Numbers;
        public int Startdiaposon { get; set; }
        public int Enddiaposon { get; set; }

        public EasyNumbers(int startdiaposon, int enddiaposon)
        {
            Startdiaposon = startdiaposon;
            Enddiaposon = enddiaposon;
        }

        public void Result()
        {
            List<int> easyNumbers = new List<int>();
            if (Startdiaposon > Enddiaposon)
            { Console.WriteLine("Invalid range."); }

            for (int i = Startdiaposon; i <= Enddiaposon; i++)
            {
                if (Yes(i))
                { easyNumbers.Add(i); }
            }

            Console.WriteLine("Easy numbers:");
            foreach (var number in easyNumbers)
            { Console.Write(number + " "); }
        }
        private bool Yes(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) { return false; }
            }
            return true;
        }
    }
}
